using AutoMapper;
using AutoMapper.QueryableExtensions;
using Codi.Core.BLL.Exceptions;
using Codi.Core.BLL.Extentions;
using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Project;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Codi.Core.Common.DTO.Git;
using Codi.Core.BLL.RabbitMQ.Abstract;
using Codi.Core.Common.DTO.Build;
using Codi.Core.Common.Enums;
using Codi.Core.Common.Helpers;

namespace Codi.Core.BLL.Services;

public class ProjectService : BaseService, IProjectService
{
    private protected readonly IProjectRepository _projectsRepository;
    private protected readonly IFileRepository _fileRepository;
    private protected readonly ITemplateRepository _templateRepository;
    private protected readonly IGitService _gitService;
    private protected readonly IBuilderProducer _builderProducer;
    private protected readonly IGithubClient _gitClient;
    private protected readonly ICredentialsService _credentialsService;
    public ProjectService(
        CodiCoreContext context,
        IMapper mapper,
        IFileRepository fileRepository,
        IProjectRepository projectsRepository,
        ITemplateRepository templateRepository,
        IGitService gitService,
        IBuilderProducer builderProducer,
        IGithubClient gitClient, 
        ICredentialsService credentialsService) : base(context, mapper)
    {
        _projectsRepository = projectsRepository;
        _fileRepository = fileRepository;
        _templateRepository = templateRepository;
        _gitService = gitService;
        _builderProducer = builderProducer;
        _gitClient = gitClient;
        _credentialsService = credentialsService;
    }

    public async Task<ICollection<ProjectDto>> GetAllAsync(Expression<Func<Project, bool>>? predicate = null)
    {
        IQueryable<Project> projects = _context.Projects;

        if (predicate != null)
        {
            projects = projects.Where(predicate);
        }

        return await projects
            .ProjectTo<ProjectDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
    }

    public async Task<ICollection<ProjectNameDto>> GetUserProjectNames(string firebaseId)
    {
        return await _context.UserProjects
            .Include(up => up.Project)
            .Include(up => up.User)
            .Where(up => up.User.FirebaseId == firebaseId)
            .Select(up => up.Project)
            .ProjectToListAsync<ProjectNameDto>(_mapper.ConfigurationProvider);
    }

    public async Task<ICollection<ProjectDto>> GetUserProjects(string firebaseId)
    {
        return await _context.UserProjects
            .Include(up => up.Project)
            .Include(up => up.User)
            .Where(up => up.User.FirebaseId == firebaseId)
            .Select(up => up.Project)
            .ProjectToListAsync<ProjectDto>(_mapper.ConfigurationProvider);
    }

    public async Task<ICollection<ProjectWithLanguageDto>> GetLastUserProjects(string firebaseId)
    {
        return await _context.UserProjects
            .Include(up => up.Project)
            .Include(up => up.User)
            .Where(up => up.User.FirebaseId == firebaseId)
            .Select(up => up.Project)
            .OrderByDescending(p => p.CreatedAt)
            .Take(5)
            .ProjectToListAsync<ProjectWithLanguageDto>(_mapper.ConfigurationProvider);
    }

    public async Task<ICollection<ProjectWithLanguageDto>> GetLastUserProjectsById(long userId)
    {
        return await _context.UserProjects
            .Include(up => up.Project)
            .Include(up => up.User)
            .Where(up => up.User.Id == userId && up.Project.IsPublic)
            .Select(up => up.Project)
            .OrderByDescending(p => p.CreatedAt)
            .Take(5)
            .ProjectToListAsync<ProjectWithLanguageDto>(_mapper.ConfigurationProvider);
    }

    public async Task<ProjectDto> GetByIdAsync(long projectId)
    {
        var project = await _context.Projects
            .Where(a => a.Id == projectId)
            .ProjectTo<ProjectDto>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync();

        if (project == null)
        {
            throw new NotFoundException(nameof(Project), projectId);
        }

        return project;
    }

    public async Task<ProjectDto> CreateUserProjectAsync(NewProjectDto newProjectDto)
    {
        var owner = await _context.Users
            .FirstOrDefaultAsync(u => u.FirebaseId == newProjectDto.FirebaseId);

        if (owner == null)
        {
            throw new NotFoundException(nameof(User));
        }

        var createdProject = await CreateAsync(newProjectDto);

        var userProject = new UserProject()
        {
            ProjectId = createdProject.Id,
            UserId = owner.Id
        };

        _context.Add(userProject);
        await _context.SaveChangesAsync();

        return _mapper.Map<ProjectDto>(createdProject);
    }

    public async Task<ProjectDto> CreateAsync(NewProjectDto newProjectDto)
    {
        var templateDocument = await _templateRepository.GetByIdAsync(newProjectDto.TemplateId);

        if (templateDocument == null)
        {
            throw new NotFoundException(nameof(templateDocument));
        }

        var projectDocument = new DAL.NoSql.Entities.Project
        {
            Id = Guid.NewGuid(),
            Nodes = await _fileRepository.DublicateFileStructure(templateDocument.Nodes),
        };

        await _projectsRepository.InsertOneAsync(projectDocument);

        var project = _mapper.Map<Project>(newProjectDto,
            opts => opts.AfterMap((src, dst) =>
        {
            dst.CreatedAt = DateTime.UtcNow;
            dst.ProjectDocumentId = projectDocument.Id;
            dst.Language = templateDocument.Language;
        }));

        var createdProject = _context.Add(project).Entity;
        await _context.SaveChangesAsync();

        return _mapper.Map<ProjectDto>(createdProject);
    }

    public async Task<ProjectDto> ImportProjectFromGithubAsync(GitCloneDto gitCloneDto)
    {
        var owner = await _context.Users
            .FirstOrDefaultAsync(u => u.FirebaseId == gitCloneDto.FirebaseId);

        if (owner == null)
        {
            throw new NotFoundException(nameof(User));
        }
        var projectDocumentId = await _gitService.CloneProject(gitCloneDto);
        if (projectDocumentId == Guid.Empty)
        {
            throw new InvalidOperationException("Project wasn't imported");
        }

        var accessToken = await _credentialsService.GetUserAccessToken(gitCloneDto.FirebaseId);
        var projResponse = await _gitClient.GetRepo(gitCloneDto.Url.Replace("github.com", "api.github.com/repos"), accessToken.Token);
        var result = ProjectHelper.LanguageComparation(projResponse.Language);
        var project = new Project()
        {
            Title = gitCloneDto.Title,
            CreatedAt = DateTime.UtcNow,
            IsPublic = gitCloneDto.IsPublic,
            IsGitImported = true,
            Stars = projResponse.Stars,
            Language = result,
            ProjectDocumentId = projectDocumentId
        };
        _context.Add(project);
        await _context.SaveChangesAsync();

        var userProject = new UserProject()
        {
            ProjectId = project.Id,
            UserId = owner.Id
        };

        _context.Add(userProject);
        await _context.SaveChangesAsync();

        return await GetByIdAsync(project.Id);
    }

    public async Task SendProjectRunRequest(long projectId, string userId)
    {
        var owner = await _context.Users
            .FirstOrDefaultAsync(u => u.FirebaseId == userId);

        if (owner == null)
        {
            throw new NotFoundException(nameof(User));
        }

        var canRun = await IsUserEditableAsync(userId, projectId);
        var project = await _context.Projects
            .FirstOrDefaultAsync(p => p.Id == projectId && (canRun || p.IsPublic));

        if (project == null)
        {
            throw new NotFoundException(nameof(Project));
        }

        if(project.Language == null)
        {
            throw new ArgumentException("To run project, first set its language");
        }

        _builderProducer.SendRunProjectRequest(new BuildProjectRequestDto
        {
            ProjectId = projectId,
            Title = project.Title,
            Language = project.Language.Value,
            ProjectDocumentId = project.ProjectDocumentId,
            UserId = userId,
            TimeStamp = DateTime.Now
        });
    }

    public async Task SendProjectStopRequest(long projectId, string userId)
    {
        var owner = await _context.Users
            .FirstOrDefaultAsync(u => u.FirebaseId == userId);

        if (owner == null)
        {
            throw new NotFoundException(nameof(User));
        }

        var canStop = await IsUserEditableAsync(userId, projectId);
        var project = await _context.Projects
            .FirstOrDefaultAsync(p => p.Id == projectId && (canStop || p.IsPublic));

        if (project == null)
        {
            throw new NotFoundException(nameof(Project));
        }

        _builderProducer.SendStopProjectRequest(new StopProjectRequestDto
        {
            ProjectId = projectId,
            UserId = userId,
            TimeStamp = DateTime.Now
        });
    }

    public async Task SendProjectInput(long projectId, string userId, string value)
    {
        var owner = await _context.Users
            .FirstOrDefaultAsync(u => u.FirebaseId == userId);

        if (owner == null)
        {
            throw new NotFoundException(nameof(User));
        }

        var canSend = await IsUserEditableAsync(userId, projectId);
        var project = await _context.Projects
            .FirstOrDefaultAsync(p => p.Id == projectId && (canSend || p.IsPublic));

        if (project == null)
        {
            throw new NotFoundException(nameof(Project));
        }

        _builderProducer.SendProjectInput(new ProjectInputDto
        {
            ProjectId = projectId,
            UserId = userId,
            Input = value,
            TimeStamp = DateTime.Now
        });
    }

    public async Task<ProjectDto> UpdateAsync(long projectId, UpdateProjectDto newProjectDto)
    {
        var existedProject = await _context.Projects.FirstOrDefaultAsync(s => s.Id == projectId);

        if (existedProject == null)
        {
            throw new NotFoundException(nameof(Project), projectId);
        }

        var mergedProject = _mapper.Map(newProjectDto, existedProject);

        var updatedProject = _context.Update(mergedProject).Entity;
        await _context.SaveChangesAsync();

        return _mapper.Map<ProjectDto>(updatedProject);
    }

    public async Task<bool> IsUserEditableAsync(string firebaseId, long projectId)
    {
        var user = await _context.Users
            .Include(u => u.UserProjects)
            .FirstOrDefaultAsync(u => u.FirebaseId == firebaseId);

        if (user is null)
        {
            throw new NotFoundException(nameof(User));
        }

        var courseUser = await _context.CourseUsers
            .Include(cu => cu.Course)
            .ThenInclude(c => c.Lessons)
            .FirstOrDefaultAsync(cu => cu.UserId == user.Id && cu.Course.Lessons.Any(l => l.ProjectId == projectId));

        var canEditLessonProject = false;
        if (courseUser is not null)
        {
            canEditLessonProject = courseUser.CourseRole == CourseRole.Admin;
        }
        
        var canEditUserProject = user.UserProjects.Any(up => up.ProjectId == projectId);

        return canEditLessonProject || canEditUserProject;
    }

    public async Task DeleteAsync(long projectId)
    {
        var userProject = await _context.UserProjects.FirstOrDefaultAsync(up => up.ProjectId == projectId);
        var project = await _context.Projects.FirstOrDefaultAsync(s => s.Id == projectId);

        if (project == null)
        {
            throw new NotFoundException(nameof(Project), projectId);
        }

        var projectDocument = await _projectsRepository.GetByIdAsync(project.ProjectDocumentId);

        if (projectDocument == null)
        {
            throw new NotFoundException(nameof(projectDocument));
        }

        await _fileRepository.DeleteFiles(projectDocument.Nodes);
        await _projectsRepository.DeleteByIdAsync(projectDocument.Id);

        _context.Remove(userProject);
        _context.Remove(project);

        await _context.SaveChangesAsync();
    }
}
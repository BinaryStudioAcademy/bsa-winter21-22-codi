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
using Codi.Core.Common.Enums;

namespace Codi.Core.BLL.Services;

public class ProjectService : BaseService, IProjectService
{
    private protected readonly IProjectRepository _projectsRepository;
    private protected readonly IFileRepository _fileRepository;
    private protected readonly ITemplateRepository _templateRepository;
    private protected readonly IGitService _gitService;
    private readonly IGithubClient _gitClient;

    public ProjectService(
        CodiCoreContext context,
        IMapper mapper,
        IFileRepository fileRepository,
        IProjectRepository projectsRepository,
        ITemplateRepository templateRepository,
        IGitService gitService,
        IGithubClient gitClient
        ) : base(context, mapper)
    {
        _projectsRepository = projectsRepository;
        _fileRepository = fileRepository;
        _templateRepository = templateRepository;
        _gitService = gitService;
        _gitClient = gitClient;
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
        return await _context.Projects
            .Include(p => p.Owner)
            .Where(p => p.Owner.FirebaseId == firebaseId)
            .ProjectToListAsync<ProjectNameDto>(_mapper.ConfigurationProvider);
    }

    public async Task<ICollection<ProjectDto>> GetUserProjects(string firebaseId)
    {
        return await _context.Projects
            .Include(p => p.Owner)
            .Where(p => p.Owner.FirebaseId == firebaseId && !p.IsGitImported)
            .ProjectToListAsync<ProjectDto>(_mapper.ConfigurationProvider);
    }

    public async Task<ICollection<ProjectDto>> GetUserGitProjects(string firebaseId)
    {
        return await _context.Projects
            .Include(p => p.Owner)
            .Where(p => p.Owner.FirebaseId == firebaseId && p.IsGitImported)
            .ProjectToListAsync<ProjectDto>(_mapper.ConfigurationProvider);
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

    public async Task<ProjectDto> CreateAsync(NewProjectDto newProjectDto)
    {
        var owner = await _context.Users
            .FirstOrDefaultAsync(u => u.FirebaseId == newProjectDto.FirebaseId);

        if (owner == null)
        {
            throw new NotFoundException(nameof(User));
        }

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
            dst.OwnerId = owner.Id;
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
        
        var projResponse = await _gitClient.GetRepo(gitCloneDto.Url.Replace("github.com", "api.github.com/repos"));
        if (Enum.TryParse<Language>(projResponse.Language, out Language result)){}
        else
        {
            throw new InvalidOperationException("Unsupported language");
        }

        var project = new Project()
        {
            Title = gitCloneDto.Title,
            OwnerId = owner.Id,
            CreatedAt = DateTime.UtcNow,
            IsPublic = gitCloneDto.IsPublic,
            IsGitImported = true,
            Stars = projResponse.Stars,
            Language = result,
            ProjectDocumentId = projectDocumentId
        };
        _context.Add(project);
        await _context.SaveChangesAsync();
        return await GetByIdAsync(project.Id);
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

    public async Task DeleteAsync(long projectId)
    {
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

        _context.Remove(project);

        await _context.SaveChangesAsync();
    }

    public async Task<ICollection<ProjectWithLanguageDto>> GetLastUserProjects(string firebaseId)
    {
        return await _context.Projects
            .Include(p => p.Owner)
            .Where(p => p.Owner.FirebaseId == firebaseId && !p.IsGitImported)
            .OrderByDescending(p => p.CreatedAt)
            .Take(5)
            .ProjectToListAsync<ProjectWithLanguageDto>(_mapper.ConfigurationProvider);
    }

    public async Task<ICollection<ProjectWithLanguageDto>> GetLastGitUserProjects(string firebaseId)
    {
        return await _context.Projects
            .Include(p => p.Owner)
            .Where(p => p.Owner.FirebaseId == firebaseId && p.IsGitImported)
            .OrderByDescending(p => p.CreatedAt)
            .Take(5)
            .ProjectToListAsync<ProjectWithLanguageDto>(_mapper.ConfigurationProvider);
    }

    public async Task<ICollection<ProjectWithLanguageDto>> GetLastUserProjectsById(long userId)
    {
        return await _context.Projects
           .Where(p => p.IsPublic && p.OwnerId == userId)
           .OrderByDescending(p => p.CreatedAt)
           .Take(5)
           .ProjectToListAsync<ProjectWithLanguageDto>(_mapper.ConfigurationProvider);
    }
}
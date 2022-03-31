﻿using AutoMapper;
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

namespace Codi.Core.BLL.Services;

public class ProjectService : BaseService, IProjectService
{
    private protected readonly IProjectRepository _projectsRepository;
    private protected readonly IFileRepository _fileRepository;
    private protected readonly ITemplateRepository _templateRepository;
    private protected readonly IGitService _gitService;

    public ProjectService(
        CodiCoreContext context,
        IMapper mapper,
        IFileRepository fileRepository,
        IProjectRepository projectsRepository,
        ITemplateRepository templateRepository,
        IGitService gitService
        ) : base(context, mapper)
    {
        _projectsRepository = projectsRepository;
        _fileRepository = fileRepository;
        _templateRepository = templateRepository;
        _gitService = gitService;
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

    public async Task<ProjectDto> GetByIdAsync(long projectId)
    {
        var project = await _context.Projects
            .Where(a => a.Id == projectId)
            .ProjectTo<ProjectDto>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync();

        if(project == null)
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
            dst.CreatedAt = DateTime.Now;
            dst.ProjectDocumentId = projectDocument.Id;
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
        var project = new Project()
        {
            Title = gitCloneDto.Title,
            CreatedAt = DateTime.Now,
            IsPublic = gitCloneDto.IsPublic,
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
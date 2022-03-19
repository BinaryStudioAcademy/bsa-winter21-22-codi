using AutoMapper;
using AutoMapper.QueryableExtensions;
using Codi.Core.BL.Interfaces;
using Codi.Core.BLL.Exceptions;
using Codi.Core.Common.DTO.Git;
using Codi.Core.Common.DTO.Project;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Codi.Core.BL.Services;

public class ProjectService : BaseService, IProjectService
{
    private readonly IGitService _gitService;
    
    public ProjectService(
        CodiCoreContext context,
        IMapper mapper,
        IGitService gitService) : base(context, mapper)
    {
        _gitService = gitService;
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
    
    public async Task<ProjectDto> ImportProjectFromGithubAsync(GitCloneDto gitCloneDto)
    {
        var project = new Project()
        {
            Title = gitCloneDto.Title,
            OwnerId = gitCloneDto.UserId,
            CreatedAt = DateTime.Now,
            IsPublic = gitCloneDto.IsPublic
        };
        _context.Add(project);
        await _context.SaveChangesAsync();
        await _gitService.CloneProject(gitCloneDto);
        return await GetByIdAsync(project.Id);
    }
}
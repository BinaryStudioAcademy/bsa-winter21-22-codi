using Codi.Core.Common.DTO.Project;
using Codi.Core.Common.DTO.Git;
using Codi.Core.DAL.Entities;
using System.Linq.Expressions;

namespace Codi.Core.BLL.Interfaces
{
    public interface IProjectService
    {
        Task<ICollection<ProjectDto>> GetAllAsync(Expression<Func<Project, bool>>? predicate = null);
        Task<ICollection<ProjectNameDto>> GetUserProjectNames(string firebaseId);
        Task<ICollection<ProjectWithLanguageDto>> GetLastUserProjects(string firebaseId);
        Task<ICollection<ProjectWithLanguageDto>> GetLastUserProjectsById(long userId);
        Task<ICollection<ProjectWithLanguageDto>> GetLastGitUserProjects(string firebaseId);
        Task<ICollection<ProjectDto>> GetUserProjects(string firebaseId);
        Task<ICollection<ProjectDto>> GetUserGitProjects(string firebaseId);
        Task<ICollection<ProjectDto>> GetUserMyProjects(string firebaseId);
        Task<ProjectDto> GetByIdAsync(long projectId);
        Task<ProjectDto> CreateAsync(NewProjectDto newProjectDto);
        Task<ProjectDto> UpdateAsync(long projectId, UpdateProjectDto newProjectDto);
        Task<ProjectDto> ImportProjectFromGithubAsync(GitCloneDto gitCloneDto);
        Task SendProjectRunRequest(long projectId, string userId);
        Task SendProjectStopRequest(long projectId, string userId);
        Task SendProjectInput(long projectId, string userId, string value);
        Task DeleteAsync(long projectId);
    }
}

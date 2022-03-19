using Codi.Core.Common.DTO.Git;
using Codi.Core.Common.DTO.Project;

namespace Codi.Core.BL.Interfaces;

public interface IProjectService
{
    Task<ProjectDto> ImportProjectFromGithubAsync(GitCloneDto gitCloneDto);
}
using Codi.Core.Common.DTO.Git;

namespace Codi.Core.BLL.Interfaces;

public interface IGitService
{
    Task<Guid> CloneProject(GitCloneDto gitCloneDto);
}
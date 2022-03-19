using Codi.Core.Common.DTO.Git;

namespace Codi.Core.BL.Interfaces;

public interface IGitService
{
    Task CloneProject(GitCloneDto gitCloneDto);
}
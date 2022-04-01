using Codi.Core.Common.DTO.Credentials;
using Codi.Core.Common.DTO.Github;

namespace Codi.Core.BLL.Interfaces;

public interface IGithubClient
{
    Task<GithubUser> GetUserFromToken(string token);
    Task<ICollection<GithubRepository>> GetUserRepositories(string token);
    Task<AccessTokenCheckDto> CheckIfTokenValid(string token);
    Task<bool> CheckIfRepositoryAccessible(string repoName, string repoOwner, string token);
    Task<GithubRepositoryFromAPI> GetRepo(string apiUrl, string token);
}
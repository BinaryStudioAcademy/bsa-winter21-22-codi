using Codi.Core.Common.DTO.Github;

namespace Codi.Core.BLL.Interfaces;

public interface IGithubService
{
    Task<GithubUser> GetUser(string firebaseId); 
    Task<ICollection<GithubRepository>> GetUserRepositories(string firebaseId);
    Task<bool> CheckIfRepositoryAccessible(GithubRepositoryLink githubRepositoryLink);
}
using AutoMapper;
using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Github;
using Codi.Core.Common.Helpers;
using Codi.Core.DAL;

namespace Codi.Core.BLL.Services;

public class GithubService : BaseService, IGithubService
{
    private readonly IGithubClient _githubClient;
    private readonly ICredentialsService _credentialsService;

    public GithubService(
        CodiCoreContext codiCoreContext,
        IMapper mapper,
        IGithubClient githubClient,
        ICredentialsService credentialsService) : base(codiCoreContext, mapper)
    {
        _githubClient = githubClient;
        _credentialsService = credentialsService;
    }

    public async Task<GithubUser> GetUser(string firebaseId)
    {
        var accessToken = await _credentialsService.GetUserAccessToken(firebaseId);

        return await _githubClient.GetUserFromToken(accessToken.Token);
    }

    public async Task<ICollection<GithubRepository>> GetUserRepositories(string firebaseId)
    {
        var accessToken = await _credentialsService.GetUserAccessToken(firebaseId);

        return await _githubClient.GetUserRepositories(accessToken.Token);
    }

    public async Task<bool> CheckIfRepositoryAccessible(GithubRepositoryLink githubRepositoryLink)
    {
        var accessToken = await _credentialsService.GetUserAccessToken(githubRepositoryLink.FirebaseId);
        var repoName = RepositoryHelper.GetRepositoryNameFromUrl(githubRepositoryLink.Link);
        var repoOwner = RepositoryHelper.GetRepositoryOwnerFromUrl(githubRepositoryLink.Link);
        
        return await _githubClient.CheckIfRepositoryAccessible(repoName, repoOwner, accessToken.Token);
    }
}
using System.Net.Http.Headers;
using AutoMapper;
using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Credentials;
using Codi.Core.Common.DTO.Github;
using Newtonsoft.Json;

namespace Codi.Core.BLL.Services;

public class GithubClient : IGithubClient
{
    private readonly HttpClient _client;
    private readonly IMapper _mapper;
    
    public GithubClient(
        HttpClient client,
        IMapper mapper)
    {
        _client = client;
        _mapper = mapper;
    }
    
    public async Task<GithubUser> GetUserFromToken(string token)
    {
        SetUpHttpClient(token);

        var endpoint = $"/user";
        var response = await _client.GetAsync(endpoint);
        var content = await response.Content.ReadAsStringAsync();

        return JsonConvert.DeserializeObject<GithubUser>(content);
    }

    public async Task<ICollection<GithubRepository>> GetUserRepositories(string token)
    {
        SetUpHttpClient(token);

        var endpoint = $"/user/repos";

        var response = await _client.GetAsync(endpoint);
        var content = await response.Content.ReadAsStringAsync();
        
        var result = JsonConvert.DeserializeObject<ICollection<GithubRepositoryFromAPI>>(content);

        return _mapper.Map<ICollection<GithubRepository>>(result);
    }

    public async Task<GithubRepositoryFromAPI> GetRepo(string repoUrl, string token)
    {
        SetUpHttpClient(token);
        
        _client.BaseAddress = new Uri(repoUrl);
        var response = await _client.GetAsync(repoUrl);
        var content = await response.Content.ReadAsStringAsync();

        var result = JsonConvert.DeserializeObject<GithubRepositoryFromAPI>(content);

        return result;
    }
    public async Task<AccessTokenCheckDto> CheckIfTokenValid(string token)
    {
        SetUpHttpClient(token);

        var checkDto = new AccessTokenCheckDto();

        var response = await _client.GetAsync("");

        checkDto.IsSucceed = response.IsSuccessStatusCode;
        if (checkDto.IsSucceed)
            checkDto.Message = "All required scopes are set up";
        else
            checkDto.Message = "Access token does not exist";

        if(checkDto.IsSucceed)
        {
            var scopes = response.Headers.GetValues("X-OAuth-Scopes").Single().Split(", ");
            var missingScopes = new List<string>();
            
            if(!scopes.Contains("repo"))
            {
                missingScopes.Add("repo");
            }

            if(missingScopes.Any())
            {
                checkDto.IsSucceed = false;
                checkDto.Message = "Those scopes are missed: \n";
                checkDto.Message += missingScopes.Aggregate((a, b) => a + ", " + b);
            }
        }

        return checkDto;
    }
    
    public async Task<bool> CheckIfRepositoryAccessible(string repoName, string repoOwner, string token)
    {
        SetUpHttpClient(token);

        var endpoint = $"/repos/{repoOwner}/{repoName}";
        var response = await _client.GetAsync(endpoint);

        return response.IsSuccessStatusCode;
    }
    
    private void SetUpHttpClient(string token)
    {
        if (!string.IsNullOrEmpty(token))
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", token);
        }
    }
}
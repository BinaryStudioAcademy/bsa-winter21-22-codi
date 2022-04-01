using Newtonsoft.Json;

namespace Codi.Core.Common.DTO.Github;

public class GithubRepositoryFromAPI 
{
    [JsonProperty("full_name")]
    public string Name {  get; set; } = default!;
    [JsonProperty("html_url")]
    public string Url {  get; set; } = default!;
    public GithubUser Owner { get; set; } = default!;
    [JsonProperty("language")]
    public string Language { get; set; } = default!;
    [JsonProperty("stargazers_count")]
    public uint Stars {  get; set; } = default!;
}
using Newtonsoft.Json;

namespace Codi.Core.Common.DTO.Github;

public class GithubRepositoryFromAPI
{
    [JsonProperty("full_name")]
    public string Name { internal get; set; } = default!;
    [JsonProperty("html_url")]
    public string Url { internal get; set; } = default!;
    public GithubUser Owner { get; set; } = default!;
}
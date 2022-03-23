using System.Text.Json.Serialization;

namespace Codi.Core.Common.DTO.Github;

public class GithubRepositoryLink
{
    public string Link { get; set; } = default!;
    
    [JsonIgnore]
    public string? FirebaseId { get; set; }
}
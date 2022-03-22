using System.Text.Json.Serialization;

namespace Codi.Core.Common.DTO.Git;

public class GitCloneDto
{
    public string Title { get; set; } = default!;
    public string Url { get; set; } = default!;

    [JsonIgnore]
    public string? FirebaseId { get; set; }
    
    [JsonIgnore]
    public long OwnerId { get; set; }
    public bool IsPublic { get; set; }
}
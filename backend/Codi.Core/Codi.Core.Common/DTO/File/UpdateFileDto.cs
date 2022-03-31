using System.Text.Json.Serialization;

namespace Codi.Core.Common.DTO.File;

public class UpdateFileDto
{
    public Guid Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Content { get; set; } = default!;
    
    [JsonIgnore] 
    public string? FirebaseId { get; set; }
}
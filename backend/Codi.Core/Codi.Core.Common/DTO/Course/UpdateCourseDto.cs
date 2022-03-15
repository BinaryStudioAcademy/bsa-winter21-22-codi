using System.Text.Json.Serialization;

namespace Codi.Core.Common.DTO.Course;

public class UpdateCourseDto
{
    public long Id { get; set; }
    public string? DisplayName { get; set; }
    public string? Description { get; set; }
    public string? Avatar { get; set; }
    [JsonIgnore]
    public long OwnerId { get; set; }
}
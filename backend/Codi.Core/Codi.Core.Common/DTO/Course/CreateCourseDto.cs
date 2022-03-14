using System.Text.Json.Serialization;

namespace Codi.Core.Common.DTO.Course;

public class CreateCourseDto
{
    public string Name { get; set; } = default!;
    public string DisplayName { get; set; } = default!;
    [JsonIgnore]
    public long OwnerId { get; set; }
    public long OrganizationId { get; set; }
}
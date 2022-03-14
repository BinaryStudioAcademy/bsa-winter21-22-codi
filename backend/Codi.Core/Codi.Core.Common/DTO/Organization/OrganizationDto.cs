using Codi.Core.Common.DTO.Course;

namespace Codi.Core.Common.DTO.Organization;

public class OrganizationDto
{
    public long Id { get; set; }
    public string Name { get; set; } = default!;
    public long OwnerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public ICollection<CourseDto> Courses { get; set; } = default!;
}
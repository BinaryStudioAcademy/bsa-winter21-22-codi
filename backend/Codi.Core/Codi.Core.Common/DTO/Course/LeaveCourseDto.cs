using System.Text.Json.Serialization;

namespace Codi.Core.Common.DTO.Course;

public class LeaveCourseDto
{
    public long CourseId { get; set; }
    public long UserId { get; set; }
}
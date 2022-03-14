using Codi.Core.DAL.Entities;

namespace Codi.Core.Common.DTO.Course
{
    public class CourseDto 
    {
        public long Id { get; set; }
        public string Name { get; set; } = default!;
        public string? DisplayName { get; set; }
        public string? Description { get; set; }
        public string? Avatar { get; set; }
        public UserDto Owner { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

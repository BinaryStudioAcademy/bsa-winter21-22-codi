

using Codi.Core.Common.DTO.User;
using Codi.Core.Common.Enums;


namespace Codi.Core.Common.DTO.Course
{
    public class CourseUserDto
    {
        public UserDto User { get; set; } = default!;
        public CourseRole CourseRole { get; set; }
    }
}

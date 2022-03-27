

using Codi.Core.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace Codi.Core.Common.DTO.Course
{
    public class InviteCourseUserDto
    {
        public long CourseId { get; set; }
        public long UserId { get; set; }
        public CourseRole CourseRole { get; set; }
    }
}

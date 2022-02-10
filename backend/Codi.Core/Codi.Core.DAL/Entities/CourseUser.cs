namespace Codi.Core.DAL.Entities
{
    public class CourseUser : AuditEntity<long>
    {
        public long UserId { get; set; }
        public User User { get; set; } = default!;
        public long CourseId { get; set; }
        public Course Course { get; set; } = default!;
        public long CourseRoleId { get; set; }
        public CourseRole CourseRole { get; set; } = default!;
    }
}

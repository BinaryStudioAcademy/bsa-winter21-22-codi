namespace Codi.Core.DAL.Entities
{
    public class Course : AuditEntity<long>
    {
        public string Name { get; set; } = default!;
        public string? DisplayName { get; set; }
        public string? Description { get; set; }

        public long? AvatarId { get; set; }
        public Image? Avatar { get; set; }
        public long OwnerId { get; set; }
        public User Owner { get; set; } = default!;
        public long OrganizationId { get; set; }
        public Organization Organization { get; set; } = default!;
        public List<CourseUser> CourseUsers { get; set; } = default!;
        public List<Unit> Units { get; set; } = default!;
        public List<Lesson> Lessons { get; set; } = default!;
    }
}

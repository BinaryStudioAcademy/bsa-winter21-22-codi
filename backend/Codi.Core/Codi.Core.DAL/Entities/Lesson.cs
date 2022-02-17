namespace Codi.Core.DAL.Entities
{
    public class Lesson : AuditEntity<long>
    {
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsPublished { get; set; }

        public long CourseId { get; set; }
        public Course Course { get; set; } = default!;
        public long? UnitId { get; set; }
        public Unit? Unit { get; set; }
        public List<Thread> Threads { get; set; } = default!;
    }
}

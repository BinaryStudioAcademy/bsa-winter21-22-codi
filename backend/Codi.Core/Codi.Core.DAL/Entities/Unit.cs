namespace Codi.Core.DAL.Entities
{
    public class Unit : AuditEntity<long>
    {
        public string Title { get; set; } = default!;
        public List<Lesson> Lessons { get; set; } = default!;

        public long CourseId { get; set; }
        public Course Course { get; set; } = default!;
    }
}

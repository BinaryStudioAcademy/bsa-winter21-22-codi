namespace Codi.Core.DAL.Entities
{
    public class Thread : AuditEntity<long>
    {
        public int StartPosition { get; set; }
        public int EndPosition { get; set; }
        public bool IsResolved { get; set; }

        public long AuthorId { get; set; }
        public User Author { get; set; } = default!;
        public long? ProjectId { get; set; }
        public Project? Project { get; set; }
        public long? LessonId { get; set; }
        public Lesson? Lesson { get; set; }
        public List<ThreadComment> ThreadComments { get; set; } = default!;
    }
}

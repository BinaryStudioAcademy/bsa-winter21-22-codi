namespace Codi.Core.DAL.Entities
{
    public class Submission : AuditEntity<long>
    {
        public DateTime StartedDate { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? LastReviewed { get; set; }
        public bool IsSubmitted { get; set; }

        public long AuthorId { get; set; }
        public User Author { get; set; } = default!;
        public long LessonId { get; set; }
        public Lesson Lesson { get; set; } = default!;
        public UserProject UserProject { get; set; } = default!;
    }
}

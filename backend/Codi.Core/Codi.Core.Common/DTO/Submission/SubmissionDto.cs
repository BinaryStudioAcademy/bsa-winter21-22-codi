namespace Codi.Core.Common.DTO.Submission
{
    public class SubmissionDto
    {
        public long Id { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public DateTime? LastReviewed { get; set; }
        public long AuthorId { get; set; }
        public long LessonId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

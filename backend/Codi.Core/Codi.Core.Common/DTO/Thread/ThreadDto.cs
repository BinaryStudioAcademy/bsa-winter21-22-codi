namespace Codi.Core.Common.DTO.Thread
{
    public class ThreadDto
    {
        public long Id { get; set; }
        public int StartPosition { get; set; }
        public int EndPosition { get; set; }
        public bool IsResolved { get; set; }
        public long AuthorId { get; set; }
        public long? ProjectId { get; set; }
        public long? LessonId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

namespace Codi.Core.Common.DTO.Lesson
{
    public class LessonDto
    {
        public long Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsPublished { get; set; }
        public long? UnitId { get; set; }
        public long ProjectId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}

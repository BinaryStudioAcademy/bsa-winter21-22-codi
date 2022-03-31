namespace Codi.Core.Common.DTO.Lesson;

public class CreateLessonDto
{
    public string Title { get; set; } = default!;
    public string? Description { get; set; }
    public long CourseId { get; set; }
    public long? UnitId { get; set; }
    public Guid TemplateId { get; set; }
    public DateTime? DueDate { get; set; }
}
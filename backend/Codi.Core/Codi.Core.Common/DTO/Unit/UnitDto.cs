using Codi.Core.Common.DTO.Lesson;

namespace Codi.Core.Common.DTO.Unit
{
    public class UnitDto
    {
        public long Id { get; set; }
        public string Title { get; set; } = default!;
        public long CourseId { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<LessonDto> Lessons { get; set; } = default!;
    }
}

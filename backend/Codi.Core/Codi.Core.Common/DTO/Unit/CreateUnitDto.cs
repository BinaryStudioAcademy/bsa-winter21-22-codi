namespace Codi.Core.Common.DTO.Unit;

public class CreateUnitDto
{
    public string Title { get; set; } = default!;
    public long CourseId { get; set; }
}
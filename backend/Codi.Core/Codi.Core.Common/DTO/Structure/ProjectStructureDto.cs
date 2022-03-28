namespace Codi.Core.Common.DTO.Structure;

public class ProjectStructureDto
{
    public Guid Id { get; set; } = default!;
    public ICollection<FSNodeDto> Children { get; set; } = default!;
}
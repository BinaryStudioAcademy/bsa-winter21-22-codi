using Codi.Core.Common.Enums;

namespace Codi.Core.Common.DTO.Structure;

public class FSNodeDto
{
    public FSNodeType Type { get; set; }
    public string? Name { get; set; }
    public Guid? FileId { get; set; }
    public ICollection<FSNodeDto> Children { get; set; } = default!;
}
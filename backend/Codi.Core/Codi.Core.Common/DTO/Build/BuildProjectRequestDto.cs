using Codi.Core.Common.Enums;

namespace Codi.Core.Common.DTO.Build;

public class BuildProjectRequestDto
{
    public long ProjectId { get; set; }
    public string Title { get; set; } = default!;
    public Guid ProjectDocumentId { get; set; }
    public string UserId { get; set; } = default!;
    public Language Language { get; set; }
    public DateTime TimeStamp { get; set; }
}


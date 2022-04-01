namespace Codi.Core.Common.DTO.Build;

public class ProjectInputDto
{
    public long ProjectId { get; set; }
    public string UserId { get; set; } = default!;
    public string Input { get; set; } = default!;
    public DateTime TimeStamp { get; set; }
}


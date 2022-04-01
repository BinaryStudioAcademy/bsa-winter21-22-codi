namespace Codi.Core.Common.DTO.Build;

public class ProjectOutputDto
{
    public long ProjectId { get; set; }
    public string UserId { get; set; } = default!;
    public string Output { get; set; } = default!;
    public bool IsError { get; set; } = default!;
    public DateTime TimeStamp { get; set; }
}
namespace Codi.Core.Common.DTO.File;

public class FileDto
{
    public Guid Id { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Content { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
}
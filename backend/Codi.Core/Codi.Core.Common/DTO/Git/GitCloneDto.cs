namespace Codi.Core.Common.DTO.Git;

public class GitCloneDto
{
    public string Title { get; set; } = default!;
    public string Url { get; set; } = default!;
    public string Login { get; set; } = default!;
    public string Password { get; set; } = default!;
    public int UserId { get; set; } = default!;
    public bool IsPublic { get; set; }
}
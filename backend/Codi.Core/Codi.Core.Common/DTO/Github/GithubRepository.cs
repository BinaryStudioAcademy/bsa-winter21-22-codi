namespace Codi.Core.Common.DTO.Github;

public class GithubRepository
{
    public string Name { get; set; } = default!;
    public string Url { get; set; } = default!;
    public GithubUser Owner { get; set; } = default!;
    public string Language { get; set;} = default!;
    public uint Stars { get; set; } = default!;
    public bool IsPrivate { get; set; } = default!;
    public string? Description { get; set; }
}
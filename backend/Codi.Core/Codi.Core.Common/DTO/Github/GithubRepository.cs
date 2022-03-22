namespace Codi.Core.Common.DTO.Github;

public class GithubRepository
{
    public string Name { get; set; } = default!;
    public string Url { get; set; } = default!;
    public GithubUser Owner { get; set; } = default!;
}
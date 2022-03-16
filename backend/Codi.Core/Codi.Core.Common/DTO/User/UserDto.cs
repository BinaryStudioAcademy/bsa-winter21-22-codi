namespace Codi.Core.Common.DTO.User;

public class UserDto
{
    public long Id { get; set; }
    public string UserName { get; set; } = default!;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Bio { get; set; }
    public string Email { get; set; } = default!;
    public string? Avatar { get; set; }
}


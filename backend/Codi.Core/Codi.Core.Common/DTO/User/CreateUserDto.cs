namespace Codi.Core.Common.DTO.User;

public class CreateUserDto
{
    public string FirebaseId { get; set; } = default!;
    public string? Username { get; set; }
    public string? Email { get; set; }
}
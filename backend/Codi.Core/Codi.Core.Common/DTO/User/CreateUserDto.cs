namespace Codi.Core.DAL.Entities;

public class CreateUserDto
{
    public string FirebaseId { get; set; } = default!;
    public string? Username { get; set; }
    public string? Email { get; set; }
}
using Codi.Core.Common.DTO.User;

namespace Codi.Core.BLL.Interfaces;

public interface IUserService
{
    Task<UserDto> CreateUserAsync(CreateUserDto user);
    Task<UserDto> GetUserByIdAsync(long id);
    Task<UserDto> GetUserByFirebaseIdAsync(string id);
    Task<long> GetUserIdByFirebaseAsync(string id);
    Task<UserDto> UpdateUserAsync(long userId, UserDto user);
    Task<ICollection<UserDto>> GetUserByNameAsync(string name, long userId);
    Task<bool> GetEmailForValidationAsync(string email);
}
using Codi.Core.Common.DTO.User;

namespace Codi.Core.BL.Interfaces;

public interface IUserService
{
    Task<UserDto> CreateUserAsync(CreateUserDto user);
    Task<UserDto> GetUserByIdAsync(long id);
    Task<UserDto> GetUserByFirebaseIdAsync(string id);
    Task<UserDto> UpdateUserAsync(UserDto user);
}
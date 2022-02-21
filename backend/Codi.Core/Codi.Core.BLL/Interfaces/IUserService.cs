using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.Interfaces;

public interface IUserService
{
    Task<UserDto> Create(CreateUserDto user);
    Task<UserDto> GetById(long id);
    Task<UserDto> GetByFirebaseId(string id);
    Task<UserDto> Update(UserDto user);
}
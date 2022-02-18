using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.Interfaces;

public interface IUserService
{
    Task<UserDto> GetById(long id);
    Task<UserDto> GetByEmail(string email);
    Task Update(UpdateUserDto user);
}
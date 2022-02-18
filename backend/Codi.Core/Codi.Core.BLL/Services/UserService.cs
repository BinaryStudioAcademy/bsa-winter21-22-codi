using AutoMapper;
using Codi.Core.BL.Interfaces;
using Codi.Core.BLL.Exceptions;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Codi.Core.BL.Services;

public class UserService : BaseService, IUserService
{
    public UserService(CodiCoreContext context, IMapper mapper) : base(context, mapper) { }

    public async Task<UserDto> GetById(long id)
    {
        var userEntity = await _context.Users
            .Include(u=>u.Avatar)
            .FirstOrDefaultAsync(u => u.Id == id);
        
        if (userEntity is null)
        {
            throw new NotFoundException<long>(nameof(User), id);
        }
        return _mapper.Map<UserDto>(userEntity);
    }
    
    public async Task<UserDto> GetByEmail(string email)
    {
        var userEntity = await _context.Users
            .Include(u=>u.Avatar)
            .FirstOrDefaultAsync(u => u.Email == email);
        return _mapper.Map<UserDto>(userEntity);
    }

    public async Task<UserDto> Update(UpdateUserDto user)
    {
        var userEntity = await _context.Users
            .Include(u=>u.Avatar)
            .FirstOrDefaultAsync(u => u.Id == user.Id);
        if (userEntity is null)
        {
            throw new NotFoundException<long>(nameof(User), user.Id);
        }
        
        userEntity.UserName = user.UserName;
        userEntity.FirstName = user.FirstName;
        userEntity.LastName = user.LastName;
        userEntity.Bio = user.Bio;
        
        if (!string.IsNullOrEmpty(user.Avatar))
        {
            if (userEntity.Avatar == null)
            {
                userEntity.Avatar = new Image
                {
                    URL = user.Avatar
                };
            }
            else
            {
                userEntity.Avatar.URL = user.Avatar;
            }
        }
        else
        {
            if (userEntity.Avatar != null)
            {
                _context.Images.Remove(userEntity.Avatar);
            }
        }

        _context.Users.Update(userEntity);
        await _context.SaveChangesAsync();
        return _mapper.Map<UserDto>(userEntity);
    }
}
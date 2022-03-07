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

    public async Task<UserDto> CreateUserAsync(CreateUserDto userDto)
    {
        var user = _mapper.Map<User>(userDto, opts => opts.AfterMap((src, dst) =>
        {
            dst.CreatedAt = DateTime.Now;
        }));

        var createdUser = _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return _mapper.Map<UserDto>(createdUser.Entity);
    }

    public async Task<UserDto> GetUserByIdAsync(long id)
    {
        var userEntity = await _context.Users
            .Include(u => u.Avatar)
            .FirstOrDefaultAsync(u => u.Id == id);
        
        if (userEntity is null)
        {
            throw new NotFoundException(nameof(User), id);
        }
        return _mapper.Map<UserDto>(userEntity);
    }
    
    public async Task<UserDto> GetUserByFirebaseIdAsync(string id)
    {
        var userEntity = await _context.Users
            .Include(u => u.Avatar)
            .FirstOrDefaultAsync(u => u.FirebaseId == id);
        return _mapper.Map<UserDto>(userEntity);
    }

    public async Task<UserDto> UpdateUserAsync(UserDto userDto)
    {
        var userEntity = await _context.Users
            .Include(u => u.Avatar)
            .FirstOrDefaultAsync(u => u.Id == userDto.Id);
        if (userEntity is null)
        {
            throw new NotFoundException(nameof(User), userDto.Id);
        }

        var mergedUser = _mapper.Map(userDto, userEntity);

        _context.Users.Update(mergedUser);
        await _context.SaveChangesAsync();
        return await GetUserByIdAsync(userEntity.Id);
    }
}
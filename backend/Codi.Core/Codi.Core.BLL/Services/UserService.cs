using AutoMapper;
using Codi.Core.BL.Interfaces;
using Codi.Core.BLL.Exceptions;
using Codi.Core.Common.DTO.User;
using Codi.Core.Common.Helpers;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Codi.Core.BL.Services;

public class UserService : BaseService, IUserService
{
    public UserService(CodiCoreContext context, IMapper mapper) : base(context, mapper) { }

    public async Task<UserDto> CreateUserAsync(CreateUserDto userDto)
    {
        var existedUser = await _context.Users
            .Include(u => u.Avatar)
            .FirstOrDefaultAsync(u => u.FirebaseId == userDto.FirebaseId);
        if (existedUser is not null)
        {
            return _mapper.Map<UserDto>(existedUser);
        }

        var user = _mapper.Map<User>(userDto, opts => opts.AfterMap((src, dst) =>
        {
            dst.UserName = UsernameHelper.OmitSpecialCharacters(dst.UserName);
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
        
        if (userEntity is null)
        {
            throw new NotFoundException(nameof(User));
        }
        return _mapper.Map<UserDto>(userEntity);
    }

    public async Task<long> GetUserIdByFirebaseAsync(string id)
    {
        return (await GetUserByFirebaseIdAsync(id)).Id;
    }

    public async Task<UserDto> UpdateUserAsync(long userId, UserDto userDto)
    {
        var userEntity = await _context.Users
            .Include(u => u.Avatar)
            .FirstOrDefaultAsync(u => u.Id == userId);
        if (userEntity is null || userDto.Id != userEntity.Id)
        {
            throw new NotFoundException(nameof(User), userId);
        }

        var mergedUser = _mapper.Map(userDto, userEntity);

        _context.Users.Update(mergedUser);
        await _context.SaveChangesAsync();
        return await GetUserByIdAsync(userEntity.Id);
    }

    public async Task<ICollection<UserDto>> GetUserByNameAsync(string name, long userId)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new NotFoundException(nameof(User));
        }
           
        var users = await _context.Users
            .Where(u => u.UserName.Contains(name) && u.Id != userId)
            .Take(5)
            .Include(u => u.Avatar)
            .ToListAsync();

        return _mapper.Map<ICollection<UserDto>>(users);
           
    }
}
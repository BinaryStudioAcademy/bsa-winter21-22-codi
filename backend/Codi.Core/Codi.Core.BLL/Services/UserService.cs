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

    public async Task<UserDto> Create(CreateUserDto userDto)
    {
        if (await _context.Users.AnyAsync(u => u.FirebaseId == userDto.FirebaseId))
        {
            throw new InvalidOperationException("Such user already exists");
        }
        var user = _mapper.Map<User>(userDto);

        var createdUser = _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return _mapper.Map<UserDto>(createdUser.Entity);
    }

    public async Task<UserDto> GetById(long id)
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
    
    public async Task<UserDto> GetByFirebaseId(string id)
    {
        var userEntity = await _context.Users
            .Include(u => u.Avatar)
            .FirstOrDefaultAsync(u => u.FirebaseId == id);
        return _mapper.Map<UserDto>(userEntity);
    }

    public async Task<UserDto> Update(UserDto userDto)
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
        return await GetById(userEntity.Id);
    }
}
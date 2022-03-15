using Codi.Core.BL.Interfaces;
using Codi.Core.DAL.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _usersService;

    public UsersController(IUserService usersService)
    {
        _usersService = usersService;
    }

    [HttpPost]
    public async Task<ActionResult<UserDto>> CreateAsync([FromBody] CreateUserDto userDto)
    {
        return Ok(await _usersService.CreateUserAsync(userDto));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserDto>> GetByIdAsync(long id)
    {
        return Ok(await _usersService.GetUserByIdAsync(id));
    }
    
    [HttpGet("firebaseId")]
    public async Task<ActionResult<UserDto>> GetByFirebaseIdAsync(string id)
    {
        return Ok(await _usersService.GetUserByFirebaseIdAsync(id));
    }

    [HttpPut]
    public async Task<ActionResult<UserDto>> UpdateAsync([FromBody] UserDto userDto)
    {
        return Ok(await _usersService.UpdateUserAsync(userDto));
    }
}
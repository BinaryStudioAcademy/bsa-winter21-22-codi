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
    public async Task<ActionResult<UserDto>> Create([FromBody] CreateUserDto userDto)
    {
        return Ok(await _usersService.Create(userDto));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserDto>> GetUserById(long id)
    {
        return Ok(await _usersService.GetById(id));
    }
    
    [HttpGet("firebaseId")]
    public async Task<ActionResult<UserDto>> GetUserByFirebaseId(string id)
    {
        return Ok(await _usersService.GetByFirebaseId(id));
    }

    [HttpPut]
    public async Task<ActionResult<UserDto>> Update([FromBody] UserDto userDto)
    {
        return Ok(await _usersService.Update(userDto));
    }
}
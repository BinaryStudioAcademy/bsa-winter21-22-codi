using Codi.Core.BL.Interfaces;
using Codi.Core.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _usersService;

    public UsersController(IUserService usersService)
    {
        _usersService = usersService;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserDto>> GetUserById(long id)
    {
        return Ok(await _usersService.GetById(id));
    }
    
    [HttpGet("email")]
    public async Task<ActionResult<UserDto>> GetUserByEmail(string email)
    {
        return Ok(await _usersService.GetByEmail(email));
    }

    [HttpPut]
    public async Task<ActionResult<UserDto>> Update([FromBody] UserDto userDto)
    {
        return Ok(await _usersService.Update(userDto));
    }
}
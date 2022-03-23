using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.User;
using Codi.Core.WebAPI.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost]
    public async Task<ActionResult<UserDto>> CreateAsync([FromBody] CreateUserDto userDto)
    {
        return Ok(await _userService.CreateUserAsync(userDto));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserDto>> GetByIdAsync(long id)
    {
        return Ok(await _userService.GetUserByIdAsync(id));
    }

    [HttpGet("search/{name}")]
    public async Task<ActionResult<UserDto>> GetByNameAsync(string name)
    {
        var userId = await _userService.GetUserIdByFirebaseAsync(this.GetUserIdFromToken());
        return Ok(await _userService.GetUserByNameAsync(name, userId)) ;
    }

    [HttpGet("firebaseId")]
    public async Task<ActionResult<UserDto>> GetByFirebaseIdAsync(string id)
    {
        return Ok(await _userService.GetUserByFirebaseIdAsync(id));
    }

    [HttpPut]
    public async Task<ActionResult<UserDto>> UpdateAsync([FromBody] UserDto userDto)
    {
        var existingId = userDto.Id;
        userDto.Id = await _userService.GetUserIdByFirebaseAsync(this.GetUserIdFromToken());
        return Ok(await _userService.UpdateUserAsync(existingId, userDto));
    }
}
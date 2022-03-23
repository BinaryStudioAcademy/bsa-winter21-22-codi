using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Github;
using Codi.Core.WebAPI.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class GithubController : ControllerBase
{
    private readonly IGithubService _githubService;

    public GithubController(IGithubService githubService)
    {
        _githubService = githubService;
    }

    [HttpGet("user")]
    public async Task<ActionResult<GithubUser>> GetUser()
    {
        return Ok(await _githubService.GetUser(this.GetUserIdFromToken()));
    }

    [HttpGet("user/repositories")]
    public async Task<ActionResult<ICollection<GithubRepository>>> GetUserRepositories()
    {
        return Ok(await _githubService.GetUserRepositories(this.GetUserIdFromToken()));
    }
    
    [HttpPost("repo/exist")]
    public async Task<ActionResult<bool>> CheckIfRepositoryAccessible([FromBody]GithubRepositoryLink linkDto)
    {
        linkDto.FirebaseId = this.GetUserIdFromToken();
        return Ok(await _githubService.CheckIfRepositoryAccessible(linkDto));
    }
}
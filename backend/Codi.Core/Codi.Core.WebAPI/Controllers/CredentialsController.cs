using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Credentials;
using Codi.Core.WebAPI.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class CredentialsController : ControllerBase
{
    private readonly ICredentialsService _credentialsService;

    public CredentialsController(ICredentialsService credentialsService)
    {
        _credentialsService = credentialsService;
    }

    [HttpGet("token")]
    public async Task<ActionResult<AccessTokenDto>> GetUserAccessToken()
    {
        return Ok(await _credentialsService.GetUserAccessToken(this.GetUserIdFromToken()));
    }
    
    [HttpPost("token")]
    public async Task<ActionResult<AccessTokenDto>> SetUpAccessToken([FromBody]AccessTokenDto token)
    {
        token.FirebaseId = this.GetUserIdFromToken();
        return Ok(await _credentialsService.SetUpAccessToken(token));
    }
    
    [HttpPost("token/valid")]
    public async Task<ActionResult<AccessTokenCheckDto>> CheckIfTokenValid([FromBody]AccessTokenDto token)
    {
        return Ok(await _credentialsService.CheckIfTokenValid(token.Token));
    }
    
    [HttpGet("token/exist")]
    public async Task<ActionResult<bool>> CheckIfUserHasToken()
    {
        return Ok(await _credentialsService.CheckIfUserHasToken(this.GetUserIdFromToken()));
    }
}
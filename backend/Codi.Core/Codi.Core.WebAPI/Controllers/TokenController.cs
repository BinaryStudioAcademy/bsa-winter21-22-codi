
using Codi.Core.DAL.Entities;
using FirebaseAdmin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TokenController : ControllerBase
{
    [HttpPost("verify")]        
    public async Task<IActionResult> VerifyToken(TokenVerifyRequestDto request)
    {
        var auth = FirebaseAdmin.Auth.FirebaseAuth.DefaultInstance;

        try
        {
            var response = await auth.VerifyIdTokenAsync(request.Token);
            if (response != null)
                return Accepted();
        }
        catch (FirebaseException ex)
        {
            return BadRequest();
        }

        return BadRequest();
    }
    
    [HttpGet("secrets")]
    [Authorize]
    public IEnumerable<string> GetSecrets()
    {
        return new List<string>()
        {
            "This is from the secret controller",
            "Seeing this means you are authenticated",
            "You have logged in using your google account from firebase",
            "Have a nice day!!"
        };
    }
}
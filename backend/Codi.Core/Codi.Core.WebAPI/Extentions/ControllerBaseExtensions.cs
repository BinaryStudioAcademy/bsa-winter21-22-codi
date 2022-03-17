using Codi.Core.BLL.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Extentions;

public static class ControllerBaseExtensions
{
    public static string GetUserIdFromToken(this ControllerBase controller)
    {
        var claimsUserId = controller.User.Claims.FirstOrDefault(x => x.Type == "user_id")?.Value;

        if (string.IsNullOrEmpty(claimsUserId))
        {
            throw new InvalidTokenException("access");
        }

        return claimsUserId;
    }
}

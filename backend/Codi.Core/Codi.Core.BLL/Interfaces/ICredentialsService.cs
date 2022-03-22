using Codi.Core.Common.DTO.Credentials;
using Codi.Core.Common.DTO.Github;

namespace Codi.Core.BLL.Interfaces;

public interface ICredentialsService
{
    Task<AccessTokenDto> SetUpAccessToken(AccessTokenDto token);
    Task<AccessTokenDto> GetUserAccessToken(string firebaseId);
    Task<AccessTokenCheckDto> CheckIfTokenValid(string token);
    Task<bool> CheckIfUserHasToken(string firebaseId);
    Task<GithubCredentials> GetUserCredentials(string firebaseId);
}
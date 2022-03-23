using AutoMapper;
using Codi.Core.BLL.Exceptions;
using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Credentials;
using Codi.Core.Common.DTO.Github;
using Codi.Core.Common.Helpers;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Codi.Core.BLL.Services;

public class CredentialsService : BaseService, ICredentialsService
{
    private readonly IGithubClient _githubClient;
    
    public CredentialsService(
        CodiCoreContext context,
        IMapper mapper,
        IGithubClient githubClient) : base(context, mapper)
    {
        _githubClient = githubClient;
    }
    
    public async Task<AccessTokenDto> SetUpAccessToken(AccessTokenDto token)
    {
        var owner = await _context.Users
            .FirstOrDefaultAsync(u => u.FirebaseId == token.FirebaseId);

        if (owner == null)
        {
            throw new NotFoundException(nameof(User));
        }
        
        var encryptedToken = SecurityHelper.EncryptToken(token.Token);
        owner.AccessToken = encryptedToken;
        _context.Update(owner);
        await _context.SaveChangesAsync();

        return token;
    }

    public async Task<AccessTokenDto> GetUserAccessToken(string firebaseId)
    {
        var owner = await _context.Users
            .FirstOrDefaultAsync(u => u.FirebaseId == firebaseId);

        if (owner == null)
        {
            throw new NotFoundException(nameof(User));
        }

        try
        {
            var decryptedToken = SecurityHelper.DecryptToken(owner.AccessToken);
            return new AccessTokenDto()
            {
                Token = decryptedToken
            };
        }
        catch (Exception)
        {
            return new AccessTokenDto() {Token = ""};
        }
    }

    public async Task<GithubCredentials> GetUserCredentials(string firebaseId)
    {
        if (!await CheckIfUserHasToken(firebaseId))
        {
            throw new InvalidOperationException("User doesn't have access token.");
        }
        
        var token = (await GetUserAccessToken(firebaseId)).Token;
        var user = await _githubClient.GetUserFromToken(token);
        var credentials = new GithubCredentials()
        {
            Login = user.Login,
            Token = token
        };
        return credentials;
    }
    
    public async Task<bool> CheckIfUserHasToken(string firebaseId)
    {
        try
        {
            var token = await GetUserAccessToken(firebaseId);

            if (string.IsNullOrEmpty(token.Token))
            {
                return false;
            }

            var tokenIsValid = await CheckIfTokenValid(token.Token);
            return tokenIsValid.IsSucceed;
        }
        catch(Exception)
        {
            return false;
        }
    }
    
    public async Task<AccessTokenCheckDto> CheckIfTokenValid(string token)
    {
        return await _githubClient.CheckIfTokenValid(token);
    }
}
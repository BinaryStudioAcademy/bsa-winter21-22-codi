using AutoMapper;
using Codi.Core.Common.DTO.Github;

namespace Codi.Core.BLL.MappingProfiles;

public class GithubProfile: Profile
{
    public GithubProfile()
    {
        CreateMap<GithubRepositoryFromAPI, GithubRepository>();
    }
}
using System.Diagnostics;
using AutoMapper;
using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Git;
using Codi.Core.DAL;
using LibGit2Sharp;

namespace Codi.Core.BLL.Services;

public class GitService : BaseService, IGitService
{
    private readonly IProjectStructureService _projectStructureService;
    private readonly ICredentialsService _credentialsService;
    
    public GitService(
        CodiCoreContext codiCoreContext,
        IMapper mapper,
        IProjectStructureService projectStructureService,
        ICredentialsService credentialsService) : base(codiCoreContext, mapper)
    {
        _projectStructureService = projectStructureService;
        _credentialsService = credentialsService;
    }
    
    public async Task<Guid> CloneProject(GitCloneDto gitCloneDto)
    {
        string tempFolder = Path.Combine(Directory.GetCurrentDirectory(), "..\\GitTemp", Guid.NewGuid().ToString().Substring(0,5));

        if (!Directory.Exists(tempFolder + $"\\{gitCloneDto.Title}"))
        {
            Directory.CreateDirectory(tempFolder + $"\\{gitCloneDto.Title}");
        }

        try
        {
            var githubCredentials = await _credentialsService.GetUserCredentials(gitCloneDto.FirebaseId);
            var cloneOptions = new CloneOptions()
            {
                CredentialsProvider = ((url, fromUrl, types) => new UsernamePasswordCredentials()
                {
                    Username = githubCredentials.Login,
                    Password = githubCredentials.Token
                })
            };
            Repository.Clone(gitCloneDto.Url, tempFolder + $"\\{gitCloneDto.Title}\\", cloneOptions);

            _projectStructureService.DeleteTempFolder(tempFolder + $"\\{gitCloneDto.Title}\\.git");

            return await _projectStructureService.CreateProjectStructureFromFolder(tempFolder + $"\\{gitCloneDto.Title}");
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
            return Guid.Empty;
        }
        finally
        {
            _projectStructureService.DeleteTempFolder(tempFolder);
        }
    }
}
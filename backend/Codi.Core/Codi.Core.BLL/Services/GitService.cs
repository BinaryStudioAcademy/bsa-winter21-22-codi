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
        var tempFolder = GetUniqueFolderPath();
        var destinationFolder = tempFolder + $"\\{gitCloneDto.Title}";

        if (!Directory.Exists(destinationFolder))
        {
            Directory.CreateDirectory(destinationFolder);
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
            Repository.Clone(gitCloneDto.Url, destinationFolder, cloneOptions);

            _projectStructureService.DeleteTempFolder($"{destinationFolder}\\.git");

            return await _projectStructureService.CreateProjectStructureFromFolder(destinationFolder);
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

    private string GetUniqueFolderPath()
    {
        return Path.Combine(Directory.GetCurrentDirectory(), "..\\GitTemp", Guid.NewGuid().ToString().Substring(0,5));
    }
}
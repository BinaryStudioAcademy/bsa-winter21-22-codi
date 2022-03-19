using System.Diagnostics;
using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Git;
using LibGit2Sharp;

namespace Codi.Core.BLL.Services;

public class GitService : IGitService
{
    private readonly IProjectStructureService _projectStructureService;
    
    public GitService(IProjectStructureService projectStructureService)
    {
        _projectStructureService = projectStructureService;
    }
    
    public async Task CloneProject(GitCloneDto gitCloneDto)
    {
        string tempFolder = Path.Combine(Directory.GetCurrentDirectory(), "..\\GitTemp", Guid.NewGuid().ToString());

        if (!Directory.Exists(tempFolder + $"\\{gitCloneDto.Title}"))
        {
            Directory.CreateDirectory(tempFolder + $"\\{gitCloneDto.Title}");
        }

        try
        {
            var cloneOptions = new CloneOptions()
            {
                CredentialsProvider = ((url, fromUrl, types) => new UsernamePasswordCredentials()
                {
                    Username = gitCloneDto.Login,
                    Password = gitCloneDto.Password
                })
            };
            Repository.Clone(gitCloneDto.Url, tempFolder + $"\\{gitCloneDto.Title}\\", cloneOptions);
            
            _projectStructureService.DeleteTempFolder(tempFolder + $"\\{gitCloneDto.Title}\\.git");

            await _projectStructureService.CreateProjectStructureFromFolder(tempFolder + $"\\{gitCloneDto.Title}");
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
        finally
        {
            _projectStructureService.DeleteTempFolder(tempFolder);
        }
    }
}
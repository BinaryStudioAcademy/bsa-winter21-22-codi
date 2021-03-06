using System.Diagnostics;
using System.Text;
using AutoMapper;
using Codi.Core.BLL.Exceptions;
using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.File;
using Codi.Core.Common.DTO.Structure;
using Codi.Core.Common.Enums;
using Codi.Core.DAL;
using Codi.Core.DAL.NoSql.Entities;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using File = System.IO.File;

namespace Codi.Core.BLL.Services;

public class ProjectStructureService : BaseService, IProjectStructureService
{
    private readonly IFileService _fileService;
    private readonly IProjectRepository _projectRepository;
    
    public ProjectStructureService(
        CodiCoreContext context,
        IMapper mapper,
        IFileService fileService,
        IProjectRepository projectRepository) : base(context, mapper)
    {
        _fileService = fileService;
        _projectRepository = projectRepository;
    }
    
    public void DeleteTempFolder(string path)
    {
        try
        {
            File.SetAttributes(path, FileAttributes.Normal);

            string[] files = Directory.GetFiles(path);
            string[] directories = Directory.GetDirectories(path);

            foreach (var file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }
            foreach (var directory in directories)
            {
                DeleteTempFolder(directory);
            }

            Directory.Delete(path, false);
        }
        catch(Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
    }
    
    public async Task<Guid> CreateProjectStructureFromFolder(string tempFolder)
    {
        var fileStructureRoot = new FSNode()
        {
            Name = tempFolder.Substring(tempFolder.LastIndexOf('\\') + 1),
            Type = FSNodeType.Folder
        };
        
        await GetFilesRecursive(tempFolder, fileStructureRoot);
        var projectDocument = new Project
        {
            Nodes = fileStructureRoot.Nodes
        };
        await _projectRepository.InsertOneAsync(projectDocument);
        return projectDocument.Id;
    }

    public async Task<ProjectStructureDto> GetProjectStructureByIdAsync(long projectId)
    {
        var project = await _context.Projects.FirstOrDefaultAsync(p => p.Id == projectId);

        if (project is null)
        {
            throw new NotFoundException(nameof(DAL.Entities.Project), projectId);
        }

        var projectDocument = await _projectRepository.GetByIdAsync(project.ProjectDocumentId);

        return _mapper.Map<ProjectStructureDto>(projectDocument);
    }

    private async Task GetFilesRecursive(string sourseDir, FSNode fileStructureRoot)
        {
            try
            {
                foreach (string directory in Directory.GetDirectories(sourseDir))
                {
                    var dirName = directory.Substring(directory.LastIndexOf(Path.DirectorySeparatorChar) + 1);

                    var nestedFileStructure = new FSNode()
                    {
                        Type = FSNodeType.Folder,
                        Name = dirName,
                    };
                    fileStructureRoot.Nodes.Add(nestedFileStructure);
                    await GetFilesRecursive(directory, nestedFileStructure);
                }
                foreach (var file in Directory.GetFiles(sourseDir))
                {
                    var fileName = file.Substring(file.LastIndexOf(Path.DirectorySeparatorChar) + 1);
                    var dirName = sourseDir.Substring(sourseDir.LastIndexOf(Path.DirectorySeparatorChar) + 1);

                    var createFile = new CreateFileDto()
                    {
                        Name = fileName,
                        Content = await GetFileContent(file),
                    };
                    
                    var fileCreated = await _fileService.CreateFileAsync(createFile);
                    var nestedFileStructure = new FSNode()
                    {
                        FileId = fileCreated.Id,
                        Type = FSNodeType.File,
                        Name = fileName
                    };
                    fileStructureRoot.Nodes.Add(nestedFileStructure);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
    
    private async Task<string> GetFileContent(string filepath)
    {
        var fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
        using var streamReader = new StreamReader(fileStream, Encoding.UTF8);
        return await streamReader.ReadToEndAsync();
    }
}
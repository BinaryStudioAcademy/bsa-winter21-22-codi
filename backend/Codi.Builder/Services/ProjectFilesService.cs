using Codi.Builder.Interfaces;
using Codi.Core.Common.Enums;
using Codi.Core.DAL.NoSql.Entities;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Builder.Services
{
    public class ProjectFilesService : IProjectFilesService
    {
        private readonly ILogger<ProjectFilesService> _logger;
        private readonly IProjectRepository _projectRepository;
        private readonly IFileRepository _fileRepository;

        public ProjectFilesService(ILogger<ProjectFilesService> logger,
            IProjectRepository projectRepository,
            IFileRepository fileRepository)
        {
            _logger = logger;
            _projectRepository = projectRepository;
            _fileRepository = fileRepository;
        }

        public async Task CreateDockerfile(string sourcePath, string content)
        {
            var dockerFilePath = Path.Combine(sourcePath, "Dockerfile");
            await System.IO.File.WriteAllTextAsync(dockerFilePath, content);
        }

        public async Task CreateFileStructure(Guid projectId, string sourcePath)
        {
            Directory.CreateDirectory(sourcePath);
            var projectDocument = await _projectRepository.GetByIdAsync(projectId);
            await CreateFileNodes(sourcePath, projectDocument.Nodes);
        }

        private async Task CreateFileNodes(string nodesPath, ICollection<FSNode> nodes)
        {
            foreach (var node in nodes)
            {
                if (node.Type == FSNodeType.File)
                {
                    var file = await _fileRepository.GetByIdAsync(node.FileId!.Value);
                    await System.IO.File.WriteAllTextAsync(Path.Combine(nodesPath, file.Name), file.Content);
                }

                if (node.Type == FSNodeType.Folder)
                {
                    var folderPath = Path.Combine(nodesPath, node.Name!);
                    Directory.CreateDirectory(folderPath);
                    await CreateFileNodes(folderPath, node.Nodes);
                }
            }
        }

    }
}

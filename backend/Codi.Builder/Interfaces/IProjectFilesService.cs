using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Builder.Interfaces;

public interface IProjectFilesService
{
    Task CreateFileStructure(Guid projectId, string projectFileStructurePath);
    Task CreateDockerfile(string sourcePath, string content);
}
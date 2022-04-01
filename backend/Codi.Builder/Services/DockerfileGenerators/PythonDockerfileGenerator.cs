using Codi.Builder.Constants;
using Codi.Builder.Interfaces;
using System.Text;

namespace Codi.Builder.Services.DockerfileGenerators;

public class PythonDockerfileGenerator : IDockerfileGenerator
{
    public string GenerateDockerfile(string sourcePath)
    {
        var projectFiles = Directory.GetFiles(sourcePath,
         PythonConstants.EntryPointFile,
         SearchOption.TopDirectoryOnly);

        if (projectFiles.Length != 1)
        {
            throw new ArgumentException($"There must be \"{PythonConstants.EntryPointFile}\" file in the root directory");
        }

        var dockerfile = new StringBuilder();
        dockerfile.AppendLine($"FROM {PythonConstants.PythonDockerImageName}:{PythonConstants.PythonDockerImageTag}");
        dockerfile.AppendLine("WORKDIR /usr/src/app");
        dockerfile.AppendLine("COPY requirements.txt ./");
        dockerfile.AppendLine("RUN pip install --no-cache-dir -r requirements.txt");
        dockerfile.AppendLine("COPY . .");
        dockerfile.Append($"CMD [ \"python\", \"./{PythonConstants.EntryPointFile}\" ]");

        return dockerfile.Replace("\r\n", "\n").ToString();
    }
}


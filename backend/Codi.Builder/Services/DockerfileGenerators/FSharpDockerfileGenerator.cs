using Codi.Builder.Constants;
using Codi.Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace Codi.Builder.Services.DockerfileGenerators;

public class FSharpDockerfileGenerator : IDockerfileGenerator
{
    public string GenerateDockerfile(string sourcePath)
    {
        var projectFiles = Directory.GetFiles(sourcePath,
           $"*.{DotNetCoreConstants.FSharpProjectFileExtension}",
           SearchOption.TopDirectoryOnly);

        if (projectFiles.Length != 1)
        {
            throw new ArgumentException($"There must be one *.{DotNetCoreConstants.FSharpProjectFileExtension} file in the root directory");
        }

        var projectFile = projectFiles[0];
        var projFileDoc = XDocument.Load(new StreamReader(projectFile));
        var assemblyNameElement = projFileDoc.XPathSelectElement(DotNetCoreConstants.AssemblyNameXPathExpression);

        string startupDllFileName = assemblyNameElement is null
            ? $"{Path.GetFileNameWithoutExtension(projectFile)}.dll"
            : $"{assemblyNameElement.Value}.dll";

        var dockerfile = new StringBuilder();
        dockerfile.AppendLine($"FROM {DotNetCoreConstants.DotnetSdkDockerImageName}:{DotNetCoreConstants.DotnetSdkDockerImageTag} AS build-env");
        dockerfile.AppendLine("WORKDIR /app");
        dockerfile.AppendLine("COPY . ./");
        dockerfile.AppendLine("RUN dotnet restore");
        dockerfile.AppendLine("RUN dotnet publish -c Release -o out");
        dockerfile.AppendLine($"FROM {DotNetCoreConstants.DotnetRuntimeDockerImageName}:{DotNetCoreConstants.DotnetRuntimeDockerImageTag}");
        dockerfile.AppendLine("WORKDIR /app");
        dockerfile.AppendLine("COPY --from=build-env /app/out .");
        dockerfile.Append($"ENTRYPOINT [\"dotnet\", \"{startupDllFileName}\"]");

        return dockerfile.Replace("\r\n", "\n").ToString();
    }
}
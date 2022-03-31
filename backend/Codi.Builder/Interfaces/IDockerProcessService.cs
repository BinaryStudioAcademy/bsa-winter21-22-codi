using Codi.Builder.Models;
using Codi.Core.Common.DTO.Build;
using Codi.Core.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Builder.Interfaces;

public interface IDockerProcessService
{
    BuildDockerImageResult BuildDockerImage(BuildProjectRequestDto request, string sourcePath);
    DockerContainerInfo RunDockerImage(BuildDockerImageResult dockerImageResult);
    void StopContainer(DockerContainerInfo container);
    void StopContainers(List<DockerContainerInfo> containers);
}


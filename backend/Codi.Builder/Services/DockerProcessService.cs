using Codi.Builder.Interfaces;
using Codi.Builder.Models;
using Codi.Core.Common.DTO.Build;
using Codi.Core.Common.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Builder.Services;

public class DockerProcessService : IDockerProcessService
{
    private readonly ILogger<DockerProcessService> _logger;

    public DockerProcessService(ILogger<DockerProcessService> logger)
    {
        _logger = logger;
    }

    public BuildDockerImageResult BuildDockerImage(BuildProjectRequestDto request, string sourcePath)
    {
        var processInfo = new ProcessStartInfo("docker", $"build {sourcePath} --quiet")
        {
            CreateNoWindow = true,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true
        };

        int exitCode;
        string? buildImageSha256 = null;
        var errorBuilder = new StringBuilder();

        using (var process = new Process())
        {
            process.StartInfo = processInfo;

            process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
            {
                if (e.Data != null)
                {
                    errorBuilder.AppendLine(e.Data);
                }
            };

            process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
            {
                if (e.Data != null)
                {
                    buildImageSha256 = e.Data;
                }
            };

            process.Start();
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            process.WaitForExit(600000);

            if (!process.HasExited)
            {
                process.Kill();
            }

            exitCode = process.ExitCode;
            process.Close();
        }

        var result = new BuildDockerImageResult()
        {
            Result = GetBuildResultFromExitCode(exitCode),
            ProjectId = request.ProjectId,
            UserId = request.UserId,
            SourcePath = sourcePath
        };

        if (result.Result == BuildResult.Success)
        {
            result.ImageSha256 = buildImageSha256;
        }
        else
        {
            result.Error = errorBuilder.ToString();
        }

        return result;
    }

    public DockerContainerInfo RunDockerImage(BuildDockerImageResult dockerImageResult)
    {
        var containerName = Guid.NewGuid().ToString();

        var process = new Process()
        {
            StartInfo = new ProcessStartInfo("docker", $"run -i --rm --name {containerName} {dockerImageResult.ImageSha256}")
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true
            }
        };

        process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
        {
            _logger.LogError(e.Data);
        };

        process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
        {
            _logger.LogInformation(e.Data);
        };

        process.Start();
        process.BeginOutputReadLine();
        process.BeginErrorReadLine();

        return new DockerContainerInfo
        {
            ProjectId = dockerImageResult.ProjectId,
            ImageSha256 = dockerImageResult.ImageSha256!,
            UserId = dockerImageResult.UserId,
            Process = process,
            SourcePath = dockerImageResult.SourcePath,
            ContainerName = containerName
        };
    }

    public void StopContainer(DockerContainerInfo container)
    {
        var process = container.Process;
        if (!process.HasExited)
        {
            process.Kill();
        }
        process.Close();
        process.Dispose();

        using var stopConteiner = new Process()
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "docker",
                Arguments = $"stop {container.ContainerName}",
                CreateNoWindow = true
            }
        };

        stopConteiner.Start();
        stopConteiner.WaitForExit(60000);
        if (!stopConteiner.HasExited)
            stopConteiner.Kill();
        stopConteiner.Close();


        using var deleteImages = new Process()
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "docker",
                Arguments = $"rmi {container.ImageSha256}",
                CreateNoWindow = true
            }
        };

        deleteImages.Start();
        deleteImages.WaitForExit(60000);
        if (!deleteImages.HasExited) 
            deleteImages.Kill(); 
        deleteImages.Close();
    }

    public void StopContainers(List<DockerContainerInfo> containers)
    {
        containers.ForEach(c =>
        {
            var process = c.Process;

            if (!process.HasExited)
            {
                process.Kill();
            }
            process.Close();
            process.Dispose();
        });

        using var stopConteiners = new Process()
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "docker",
                Arguments = $"stop {string.Join(" ", containers.Select(c => c.ContainerName))}",
                CreateNoWindow = true
            }
        };

        stopConteiners.Start();
        stopConteiners.WaitForExit(60000);
        if (!stopConteiners.HasExited)
            stopConteiners.Kill();
        stopConteiners.Close();


        using var deleteImages = new Process()
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "docker",
                Arguments = $"rmi {string.Join(" ", containers.Select(c => c.ImageSha256))}",
                CreateNoWindow = true
            }
        };

        deleteImages.Start();
        deleteImages.WaitForExit(60000);
        if (!deleteImages.HasExited)
            deleteImages.Kill();
        deleteImages.Close();
    }


    private static BuildResult GetBuildResultFromExitCode(int exitCode)
    {
        return exitCode switch
        {
            0 => BuildResult.Success,
            _ => BuildResult.Error
        };
    }
}

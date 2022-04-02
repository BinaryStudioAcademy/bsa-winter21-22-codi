using Codi.Builder.Interfaces;
using Codi.Builder.Models;
using Codi.Builder.RabbitMQ.Abstract;
using Codi.Core.Common.DTO.Build;
using Codi.Core.Common.Enums;
using System.Diagnostics;

namespace Codi.Builder.Services;

public class ProjectBuilderService : IProjectBuilderService
{
    private readonly List<DockerContainerInfo> _workingContainers;

    private readonly ILogger<ProjectBuilderService> _logger;
    private readonly IProjectFilesService _projectFilesService;
    private readonly IDockerfileGeneratorFactory _dockerfileGeneratorFactory;
    private readonly IDockerProcessService _dockerProcessService;
    private readonly IOutputProducer _outputProducer;

    private readonly string _projectsTempFolder;

    public ProjectBuilderService(ILogger<ProjectBuilderService> logger,
        IProjectFilesService projectFilesService,
        IDockerfileGeneratorFactory dockerfileGeneratorFactory,
        IDockerProcessService dockerProcessService,
        IOutputProducer outputProducer)
    {
        _logger = logger;
        _projectFilesService = projectFilesService;
        _dockerfileGeneratorFactory = dockerfileGeneratorFactory;
        _dockerProcessService = dockerProcessService;
        _outputProducer = outputProducer;

        _projectsTempFolder = Path.Combine(Path.GetTempPath(), "CodiTemp", "Projects");
        _workingContainers = new List<DockerContainerInfo>();
    }

    public async Task Run(BuildProjectRequestDto buildRequest)
    {
        var container = _workingContainers
                .FirstOrDefault(c => c.ProjectId == buildRequest.ProjectId && c.UserId == buildRequest.UserId);

        if (container != null)
        {
            Stop(new StopProjectRequestDto
            {
                ProjectId = container.ProjectId,
                UserId = container.UserId,
                TimeStamp = DateTime.Now
            });
        };

        var projectFileStructurePath = Path.Combine(
            _projectsTempFolder,
            Path.GetFileNameWithoutExtension(Path.GetRandomFileName())
            );

        _logger.LogInformation($"Project[ID={buildRequest.ProjectId}, userId={buildRequest.UserId}] tempFolder: {projectFileStructurePath}");

        try
        {
            await _projectFilesService.CreateFileStructure(buildRequest.ProjectDocumentId, projectFileStructurePath);

            var dockerfileGenerator = _dockerfileGeneratorFactory.GetDockerfileGenerator(buildRequest.Language);
            var dockerfile = dockerfileGenerator.GenerateDockerfile(projectFileStructurePath);

            await _projectFilesService.CreateDockerfile(projectFileStructurePath, dockerfile);

            var dockerImageResult = _dockerProcessService.BuildDockerImage(buildRequest, projectFileStructurePath);

            ProcessDockerImageResult(dockerImageResult, buildRequest);
        }
        catch (Exception ex)
        {
            _logger.LogError("Error while building and running docker image.\n" + ex.Message);
            Directory.Delete(projectFileStructurePath, true);
        }
    }

    public void Stop(StopProjectRequestDto stopRequest)
    {
        var container = _workingContainers
            .FirstOrDefault(c => c.ProjectId == stopRequest.ProjectId && c.UserId == stopRequest.UserId);

        if (container == null) return;
        try
        {
            _dockerProcessService.StopContainer(container);
            _workingContainers.Remove(container);
            Directory.Delete(container.SourcePath, true);

            _logger.LogInformation($"Project[ID={stopRequest.ProjectId}, userId={stopRequest.UserId}] successfully stopped");
        }
        catch (Exception ex)
        {
            _logger.LogError("Error while stopping docker container.\n" + ex.Message);
        }
    }

    public void Input(ProjectInputDto inputDto)
    {
        var container = _workingContainers
            .FirstOrDefault(c => c.ProjectId == inputDto.ProjectId && c.UserId == inputDto.UserId);

        if (container == null) return;

        try
        {
            var inputStream = container.Process.StandardInput;
            inputStream.WriteLine(inputDto.Input);

            _logger.LogInformation($"Project[ID={inputDto.ProjectId}, userId={inputDto.UserId}]: command entered successfully");
        }
        catch (Exception ex)
        {
            _logger.LogError("Error while input data into container.\n" + ex.Message);
        }
    }

    public void Dispose()
    {
        try
        {
            _dockerProcessService.StopContainers(_workingContainers);
        }
        catch (Exception ex)
        {
            _logger.LogError("Error while stopping docker containers.\n" + ex.Message);
        }
    }

    private DataReceivedEventHandler GetDataReciviedEventHandler(BuildProjectRequestDto buildRequest, bool isError)
    {
        return (sender, args) =>
        {
            if (!string.IsNullOrEmpty(args.Data))
            {
                _outputProducer.SendProjectOutput(new ProjectOutputDto
                {
                    Output = args.Data,
                    IsError = isError,
                    ProjectId = buildRequest.ProjectId,
                    TimeStamp = DateTime.Now,
                    UserId = buildRequest.UserId,
                });
            }
        };
    }

    private void ProcessDockerImageResult(BuildDockerImageResult dockerImageResult, BuildProjectRequestDto buildRequest)
    {
        if (dockerImageResult.Result == BuildResult.Success)
        {
            var containerInfo = _dockerProcessService.RunDockerImage(dockerImageResult,
                GetDataReciviedEventHandler(buildRequest, false),
                GetDataReciviedEventHandler(buildRequest, true));

            _workingContainers.Add(containerInfo);
            _logger.LogInformation($"Project[ID={buildRequest.ProjectId}, userId={buildRequest.UserId}] successfully runned");
        }

        if (dockerImageResult.Result == BuildResult.Error)
        {
            _outputProducer.SendProjectOutput(new ProjectOutputDto
            {
                Output = dockerImageResult.Error ?? "An error occurred during the project build",
                IsError = true,
                ProjectId = buildRequest.ProjectId,
                TimeStamp = DateTime.Now,
                UserId = buildRequest.UserId,
            });
            _logger.LogError($"Project[ID={buildRequest.ProjectId}, userId={buildRequest.UserId}] error.\n" + dockerImageResult.Error);
            Directory.Delete(dockerImageResult.SourcePath, true);
        }
    }
}
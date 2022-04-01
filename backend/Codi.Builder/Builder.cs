using Codi.Builder.Interfaces;
using Codi.Builder.RabbitMQ.Abstract;
using Codi.Core.Common.DTO.Build;
using RabbitMQ.Client.Events;
using System.Text;
using System.Text.Json;

namespace Codi.Builder;

public class Builder : BackgroundService
{
    private readonly ILogger<Builder> _logger;
    private readonly IBuilderConsumer _buildConsumer;
    private readonly IProjectBuilderService _projectBuilder;

    public Builder(ILogger<Builder> logger, IBuilderConsumer buildConsumer, IProjectBuilderService projectBuilder)
    {
        _logger = logger;
        _buildConsumer = buildConsumer;
        _projectBuilder = projectBuilder;

        _buildConsumer.RunReceived += RunRequest_Received;
        _buildConsumer.StopReceived += StopRequest_Received;
        _buildConsumer.InputReceived += InputRequest_Received;
    }

    private async void RunRequest_Received(object? sender, BasicDeliverEventArgs e)
    {
        var runRequest = JsonSerializer.Deserialize<BuildProjectRequestDto>(Encoding.UTF8.GetString(e.Body.Span));

        _logger.LogInformation($"Received project run request:\n{Encoding.UTF8.GetString(e.Body.Span)}");

        if (runRequest != null)
        {
            await _projectBuilder.Run(runRequest);
        }

        _buildConsumer.SetRunAcknowledge(e.DeliveryTag, true);
    }

    private void StopRequest_Received(object? sender, BasicDeliverEventArgs e)
    {
        var stopRequest = JsonSerializer.Deserialize<StopProjectRequestDto>(Encoding.UTF8.GetString(e.Body.Span));

        _logger.LogInformation($"Received project stop request:\n{Encoding.UTF8.GetString(e.Body.Span)}");

        if(stopRequest != null)
        {
            _projectBuilder.Stop(stopRequest);
        }

        _buildConsumer.SetStopAcknowledge(e.DeliveryTag, true);
    }

    private void InputRequest_Received(object? sender, BasicDeliverEventArgs e)
    {
        var inputDto = JsonSerializer.Deserialize<ProjectInputDto>(Encoding.UTF8.GetString(e.Body.Span));

        _logger.LogInformation($"Received project input:\n{Encoding.UTF8.GetString(e.Body.Span)}");

        if (inputDto != null)
        {
            _projectBuilder.Input(inputDto);
        }

        _buildConsumer.SetInputAcknowledge(e.DeliveryTag, true);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        stoppingToken.ThrowIfCancellationRequested();

        _buildConsumer.Connect();

        _logger.LogInformation($"Builder service started...");

        await Task.CompletedTask;
    }

    public override async Task StopAsync(CancellationToken stoppingToken)
    {
        _buildConsumer.Dispose();
        _projectBuilder.Dispose();

        _logger.LogInformation("Builder service stopped...");

        await base.StopAsync(stoppingToken);
    }
}
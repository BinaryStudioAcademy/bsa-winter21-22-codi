using Codi.Core.Common.DTO.Build;
using Codi.Notifier.WebAPI.Hubs;
using Codi.Notifier.WebAPI.Hubs.Interfaces;
using Codi.Notifier.WebAPI.RabbitMQ.Abstract;
using Microsoft.AspNetCore.SignalR;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Codi.Notifier.WebAPI;

public class Consumer : BackgroundService
{
    private readonly ILogger<Consumer> _logger;
    private readonly IOutputConsumer _outputConsumer;
    private readonly IHubContext<BuildHub, IBuildHubClient> _buildContext;

    public Consumer(ILogger<Consumer> logger, IOutputConsumer outputConsumer, IHubContext<BuildHub, IBuildHubClient> buildContext)
    {
        _logger = logger;
        _outputConsumer = outputConsumer;
        _buildContext = buildContext;

        _outputConsumer.OutputReceived += ProjectOutput_Received;
    }

    private async void ProjectOutput_Received(object? sender, BasicDeliverEventArgs e)
    {
        var outputDto = JsonSerializer.Deserialize<ProjectOutputDto>(Encoding.UTF8.GetString(e.Body.Span));

        _logger.LogInformation($"Received output:\n{Encoding.UTF8.GetString(e.Body.Span)}");

        if (outputDto != null)
        {
            await _buildContext.Clients.User(outputDto.UserId).ReceiveProjectOutput(outputDto);

        }

        _outputConsumer.SetOutputAcknowledge(e.DeliveryTag, true);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        stoppingToken.ThrowIfCancellationRequested();

        _outputConsumer.Connect();

        _logger.LogInformation($"Notifier service started...");

        await Task.CompletedTask;
    }

    public override async Task StopAsync(CancellationToken stoppingToken)
    {
        _outputConsumer.Dispose();

        _logger.LogInformation("Notifier service stopped...");

        await base.StopAsync(stoppingToken);
    }
}
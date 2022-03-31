using Codi.Core.BLL.RabbitMQ.Abstract;
using Codi.Core.Common.DTO.Build;
using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using System.Text.Json;

namespace Codi.Core.BLL.RabbitMQ;

public class BuilderProducer : IBuilderProducer
{
    private readonly IMessageProducerScope _projectProducerScope;
    private readonly IMessageProducerScope _projectStopScope;
    private readonly IMessageProducerScope _projectInputScope;

    public BuilderProducer(IMessageProducerScopeFactory producerScopeFactory, 
        MessageScopeSettings projectRunScopeSettings,
        MessageScopeSettings projectStopScopeSettings,
        MessageScopeSettings projectInputScopeSettings)
    {
        _projectProducerScope = producerScopeFactory.Open(projectRunScopeSettings);
        _projectStopScope = producerScopeFactory.Open(projectStopScopeSettings);
        _projectInputScope = producerScopeFactory.Open(projectInputScopeSettings);
    }

    public void SendRunProjectRequest(BuildProjectRequestDto request)
    {
        _projectProducerScope.MessageProducer.Send(JsonSerializer.Serialize(request));
    }

    public void SendStopProjectRequest(StopProjectRequestDto request)
    {
        _projectStopScope.MessageProducer.Send(JsonSerializer.Serialize(request));
    }
    public void SendProjectInput(ProjectInputDto request)
    {
        _projectInputScope.MessageProducer.Send(JsonSerializer.Serialize(request));
    }

    public void Dispose()
    {
        _projectProducerScope.Dispose();
    }
}
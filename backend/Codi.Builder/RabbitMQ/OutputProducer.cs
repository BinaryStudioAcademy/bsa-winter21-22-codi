using Codi.Builder.RabbitMQ.Abstract;
using Codi.Core.Common.DTO.Build;
using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using System.Text.Json;

namespace Codi.Builder.RabbitMQ;

public class OutputProducer : IOutputProducer
{
    private readonly IMessageProducerScope _outputProducerScope;

    public OutputProducer(IMessageProducerScopeFactory producerScopeFactory,
        MessageScopeSettings outputProducerScopeSettings)
    {
        _outputProducerScope = producerScopeFactory.Open(outputProducerScopeSettings);
    }

    public void SendProjectOutput(ProjectOutputDto output)
    {
        _outputProducerScope.MessageProducer.Send(JsonSerializer.Serialize(output));
    }

    public void Dispose()
    {
        _outputProducerScope.Dispose();
    }
}
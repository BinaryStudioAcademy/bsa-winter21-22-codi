using Codi.RabbitMQ.Models;

namespace Codi.RabbitMQ.Interfaces;

public interface IMessageProducerScopeFactory
{
    IMessageProducerScope Open(MessageScopeSettings messageScopeSettings);
}
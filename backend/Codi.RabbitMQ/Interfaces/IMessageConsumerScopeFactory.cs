using Codi.RabbitMQ.Models;

namespace Codi.RabbitMQ.Interfaces;

public interface IMessageConsumerScopeFactory
{
    IMessageConsumerScope Open(MessageScopeSettings messageScopeSettings);
    IMessageConsumerScope Connect(MessageScopeSettings messageScopeSettings);
}
using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using RabbitMQ.Client;

namespace Codi.RabbitMQ.Services;

public class MessageConsumerScopeFactory : IMessageConsumerScopeFactory
{
    private readonly IConnectionFactory _connectionFactory;

    public MessageConsumerScopeFactory(IConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public IMessageConsumerScope Open(MessageScopeSettings messageScopeSettings)
    {
        return new MessageConsumerScope(_connectionFactory, messageScopeSettings);
    }

    public IMessageConsumerScope Connect(MessageScopeSettings messageScopeSettings)
    {
        var consumerScope = Open(messageScopeSettings);
        consumerScope.MessageConsumer.Connect();
        return consumerScope;
    }
}
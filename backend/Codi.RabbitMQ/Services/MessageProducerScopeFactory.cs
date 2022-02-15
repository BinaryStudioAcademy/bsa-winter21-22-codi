using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using RabbitMQ.Client;

namespace Codi.RabbitMQ.Services;

public class MessageProducerScopeFactory : IMessageProducerScopeFactory
{
    private readonly IConnectionFactory _connectionFactory;

    public MessageProducerScopeFactory(IConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public IMessageProducerScope Open(MessageScopeSettings messageScopeSettings)
    {
        return new MessageProducerScope(_connectionFactory, messageScopeSettings);
    }
}
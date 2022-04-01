using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using IMessageProducer = Codi.Core.BLL.RabbitMQ.Abstract.IMessageProducer;

namespace Codi.Core.BLL.RabbitMQ;

public class MessageProducer : IMessageProducer
{
    private readonly IMessageProducerScope _messageProducerScope;
    
    public MessageProducer(IMessageProducerScopeFactory messageProducerScopeFactory, MessageScopeSettings messageScopeSettings)
    {
        _messageProducerScope = messageProducerScopeFactory.Open(messageScopeSettings);
    }

    public void Dispose()
    {
        _messageProducerScope.Dispose();
    }

    public void SendMessage(string message)
    {
        _messageProducerScope.MessageProducer.Send(message);
    }
}
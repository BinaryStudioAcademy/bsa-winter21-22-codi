using Codi.Core.BL.Interfaces;
using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;

namespace Codi.Core.BLL.RabbitMQ;

public class MessageService : IMessageService
{
    private readonly IMessageProducerScope _messageProducerScope;
    
    public MessageService(IMessageProducerScopeFactory messageProducerScopeFactory, MessageScopeSettings messageScopeSettings)
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
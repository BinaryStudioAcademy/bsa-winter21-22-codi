using Codi.Core.BL.Interfaces;
using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using RabbitMQ.Client;

namespace Codi.Core.BLL.RabbitMQ;

public class MessageService : IMessageService
{
    private readonly IMessageProducerScope _messageProducerScope;
    
    public MessageService(IMessageProducerScopeFactory messageProducerScopeFactory)
    {
        _messageProducerScope = messageProducerScopeFactory.Open(new MessageScopeSettings()
        {
            ExchangeName = "WebAPI",
            ExchangeType = ExchangeType.Direct,
            QueueName = "Messages",
            RoutingKey = "message"
        });
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
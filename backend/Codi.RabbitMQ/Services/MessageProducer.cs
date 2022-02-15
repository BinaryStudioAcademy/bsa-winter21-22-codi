using System.Text;
using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using RabbitMQ.Client;

namespace Codi.RabbitMQ.Services;

public class MessageProducer : IMessageProducer
{
    private readonly MessageProducerSettings _messageProducerSettings;
    private readonly IBasicProperties _properties;

    public MessageProducer(MessageProducerSettings messageProducerSettings)
    {
        _messageProducerSettings = messageProducerSettings;

        _properties = _messageProducerSettings.Channel.CreateBasicProperties();
        _properties.Persistent = true;
    }

    public void Send(string message, string type = null)
    {
        if (!string.IsNullOrEmpty(type))
        {
            _properties.Type = type;
        }

        var body = Encoding.UTF8.GetBytes(message);
        _messageProducerSettings.Channel.BasicPublish(_messageProducerSettings.PublicationAddress, _properties, body);
    }
}
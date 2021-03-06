using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Codi.RabbitMQ.Services;

public class MessageConsumer : IMessageConsumer
{
    private readonly MessageConsumerSettings _settings;
    private readonly EventingBasicConsumer _consumer;

    public event EventHandler<BasicDeliverEventArgs> Received
    {
        add => _consumer.Received += value;
        remove => _consumer.Received -= value;
    }
    
    public MessageConsumer(MessageConsumerSettings settings)
    {
        _settings = settings;
        _consumer = new EventingBasicConsumer(_settings.Channel);
    }

    public void Connect()
    {
        if (_settings.SequentialFetch)
        {
            _settings.Channel.BasicQos(0, 1, false);
        }

        _settings.Channel.BasicConsume(_settings.QueueName, _settings.AutoAcknowledge, _consumer);
    }

    public void SetAcknowledge(ulong deliveryTag, bool processed)
    {
        if (processed)
        {
            _settings.Channel.BasicAck(deliveryTag, false);
        }
        else
        {
            _settings.Channel.BasicNack(deliveryTag, false, true);
        }
    }
}
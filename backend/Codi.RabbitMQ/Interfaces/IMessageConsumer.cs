using RabbitMQ.Client.Events;

namespace Codi.RabbitMQ.Interfaces;

public interface IMessageConsumer
{
    event EventHandler<BasicDeliverEventArgs> Received;
    void Connect();
    void SetAcknowledge(ulong deliveryTag, bool processed);
}
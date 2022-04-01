using RabbitMQ.Client.Events;

namespace Codi.Notifier.WebAPI.RabbitMQ.Abstract;

public interface IOutputConsumer : IDisposable
{
    event EventHandler<BasicDeliverEventArgs> OutputReceived;

    void Connect();
    void SetOutputAcknowledge(ulong deliveryTag, bool processed);
}
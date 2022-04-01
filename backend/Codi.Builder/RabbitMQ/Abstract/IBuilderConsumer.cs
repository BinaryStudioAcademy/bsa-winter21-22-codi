using RabbitMQ.Client.Events;

namespace Codi.Builder.RabbitMQ.Abstract;

public interface IBuilderConsumer : IDisposable
{
    event EventHandler<BasicDeliverEventArgs> RunReceived;
    event EventHandler<BasicDeliverEventArgs> StopReceived;
    event EventHandler<BasicDeliverEventArgs> InputReceived;

    void Connect();
    void SetRunAcknowledge(ulong deliveryTag, bool processed);
    void SetStopAcknowledge(ulong deliveryTag, bool processed);
    void SetInputAcknowledge(ulong deliveryTag, bool processed);
}
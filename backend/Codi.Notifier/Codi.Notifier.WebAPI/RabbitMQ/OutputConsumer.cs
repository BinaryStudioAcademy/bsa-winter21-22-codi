using Codi.Notifier.WebAPI.RabbitMQ.Abstract;
using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using RabbitMQ.Client.Events;

namespace Codi.Notifier.WebAPI.RabbitMQ;

public class OutputConsumer : IOutputConsumer
{
    private readonly IMessageConsumerScope _projectOutputConsumerScope;

    public event EventHandler<BasicDeliverEventArgs> OutputReceived
    {
        add => _projectOutputConsumerScope.MessageConsumer.Received += value;
        remove => _projectOutputConsumerScope.MessageConsumer.Received -= value;
    }

    public OutputConsumer(IMessageConsumerScopeFactory consumerScopeFactory,
        MessageScopeSettings projectRunScopeSettings)
    {
        _projectOutputConsumerScope = consumerScopeFactory.Open(projectRunScopeSettings);
    }

    public void Connect()
    {
        _projectOutputConsumerScope.MessageConsumer.Connect();
    }

    public void SetOutputAcknowledge(ulong deliveryTag, bool processed)
    {
        _projectOutputConsumerScope.MessageConsumer.SetAcknowledge(deliveryTag, processed);
    }

    public void Dispose()
    {
        _projectOutputConsumerScope.Dispose();
    }
}


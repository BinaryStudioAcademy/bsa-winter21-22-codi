using Codi.Builder.RabbitMQ.Abstract;
using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Builder.RabbitMQ;

public class BuilderConsumer : IBuilderConsumer
{
    private readonly IMessageConsumerScope _projectRunConsumerScope;
    private readonly IMessageConsumerScope _projectStopConsumerScope;
    private readonly IMessageConsumerScope _projectInputConsumerScope;

    public event EventHandler<BasicDeliverEventArgs> RunReceived
    {
        add => _projectRunConsumerScope.MessageConsumer.Received += value;
        remove => _projectRunConsumerScope.MessageConsumer.Received -= value;
    }

    public event EventHandler<BasicDeliverEventArgs> StopReceived
    {
        add => _projectStopConsumerScope.MessageConsumer.Received += value;
        remove => _projectStopConsumerScope.MessageConsumer.Received -= value;
    }

    public event EventHandler<BasicDeliverEventArgs> InputReceived
    {
        add => _projectInputConsumerScope.MessageConsumer.Received += value;
        remove => _projectInputConsumerScope.MessageConsumer.Received -= value;
    }

    public BuilderConsumer(IMessageConsumerScopeFactory consumerScopeFactory,
        MessageScopeSettings projectRunScopeSettings,
        MessageScopeSettings projectStopScopeSettings,
        MessageScopeSettings projectInputScopeSettings)
    {
        _projectRunConsumerScope = consumerScopeFactory.Open(projectRunScopeSettings);
        _projectStopConsumerScope = consumerScopeFactory.Open(projectStopScopeSettings);
        _projectInputConsumerScope = consumerScopeFactory.Open(projectInputScopeSettings);
    }

    public void Connect()
    {
        _projectRunConsumerScope.MessageConsumer.Connect();
        _projectStopConsumerScope.MessageConsumer.Connect();
        _projectInputConsumerScope.MessageConsumer.Connect();
    }

    public void SetRunAcknowledge(ulong deliveryTag, bool processed)
    {
        _projectRunConsumerScope.MessageConsumer.SetAcknowledge(deliveryTag, processed);
    }

    public void SetStopAcknowledge(ulong deliveryTag, bool processed)
    {
        _projectStopConsumerScope.MessageConsumer.SetAcknowledge(deliveryTag, processed);
    }

    public void SetInputAcknowledge(ulong deliveryTag, bool processed)
    {
        _projectInputConsumerScope.MessageConsumer.SetAcknowledge(deliveryTag, processed);
    }

    public void Dispose()
    {
        _projectRunConsumerScope.Dispose();
        _projectStopConsumerScope.Dispose();
        _projectInputConsumerScope.Dispose();
    }
}


using RabbitMQ.Client;

namespace Codi.RabbitMQ.Models;

public class MessageConsumerSettings
{
    public bool SequentialFetch { get; set; } = true;
    public bool AutoAcknowledge { get; set; } = false;
    public IModel Channel { get; set; }
    public string QueueName { get; set; }
}
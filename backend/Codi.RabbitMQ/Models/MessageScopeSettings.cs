namespace Codi.RabbitMQ.Models;

public class MessageScopeSettings
{
    public string ExchangeName { get; set; }
    public string QueueName { get; set; }
    public string RoutingKey { get; set; }
    public string ExchangeType { get; set; }
}
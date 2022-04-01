namespace Codi.RabbitMQ.Models;

public class MessageScopeSettings
{
    public string ExchangeName { get; set; } = default!;
    public string QueueName { get; set; } = default!;
    public string RoutingKey { get; set; } = default!;
    public string ExchangeType { get; set; } = default!;
}
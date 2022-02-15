using RabbitMQ.Client;

namespace Codi.RabbitMQ.Interfaces;

public interface IMessageQueue : IDisposable
{
    IModel Channel { get; set; }
}
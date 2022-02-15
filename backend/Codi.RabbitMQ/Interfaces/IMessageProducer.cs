namespace Codi.RabbitMQ.Interfaces;

public interface IMessageProducer
{
    void Send(string message, string type = null);
}
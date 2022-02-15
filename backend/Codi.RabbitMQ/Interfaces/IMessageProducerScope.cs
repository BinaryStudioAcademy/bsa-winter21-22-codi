namespace Codi.RabbitMQ.Interfaces;

public interface IMessageProducerScope : IDisposable
{
    IMessageProducer MessageProducer { get; }
}
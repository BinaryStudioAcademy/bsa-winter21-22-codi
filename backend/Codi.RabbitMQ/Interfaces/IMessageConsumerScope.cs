namespace Codi.RabbitMQ.Interfaces;

public interface IMessageConsumerScope : IDisposable
{
    IMessageConsumer MessageConsumer { get;}
}
namespace Codi.Core.BLL.RabbitMQ.Abstract;

public interface IMessageProducer : IDisposable
{
    void SendMessage(string message);
}
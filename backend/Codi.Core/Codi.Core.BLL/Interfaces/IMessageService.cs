namespace Codi.Core.BLL.Interfaces;

public interface IMessageService : IDisposable
{
    void SendMessage(string message);
}
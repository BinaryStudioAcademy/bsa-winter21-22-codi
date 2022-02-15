namespace Codi.Core.BL.Interfaces;

public interface IMessageService : IDisposable
{
    void SendMessage(string message);
}
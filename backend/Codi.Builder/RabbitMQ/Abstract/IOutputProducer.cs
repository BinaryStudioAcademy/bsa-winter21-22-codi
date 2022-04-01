using Codi.Core.Common.DTO.Build;

namespace Codi.Builder.RabbitMQ.Abstract;

public interface IOutputProducer : IDisposable
{
    void SendProjectOutput(ProjectOutputDto output);
}


using Codi.Core.Common.DTO.Build;

namespace Codi.Core.BLL.RabbitMQ.Abstract;

public interface IBuilderProducer : IDisposable
{
    void SendRunProjectRequest(BuildProjectRequestDto request);
    void SendStopProjectRequest(StopProjectRequestDto request);
    void SendProjectInput(ProjectInputDto request);
}
using Codi.Core.Common.DTO.Build;

namespace Codi.Builder.Interfaces;

public interface IProjectBuilderService : IDisposable
{
    Task Run(BuildProjectRequestDto buildRequest);
    void Stop(StopProjectRequestDto stopRequest);
    void Input(ProjectInputDto inputDto);
}
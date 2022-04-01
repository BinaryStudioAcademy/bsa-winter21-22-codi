using Codi.Core.Common.DTO.Build;

namespace Codi.Notifier.WebAPI.Hubs.Interfaces;

public interface IBuildHubClient
{
    Task ReceiveProjectOutput(ProjectOutputDto projectOutput);
}

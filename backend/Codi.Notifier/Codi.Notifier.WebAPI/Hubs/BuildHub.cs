using Codi.Notifier.WebAPI.Hubs.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace Codi.Notifier.WebAPI.Hubs;

public class BuildHub : Hub<IBuildHubClient>
{
}

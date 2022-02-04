using Microsoft.AspNetCore.SignalR;
using Codi.Notifier.Hubs.Interfaces;

namespace Codi.Notifier.Hubs
{
    public class BroadcastHub : Hub<IBroadcastHubClient>
    {
    }
}
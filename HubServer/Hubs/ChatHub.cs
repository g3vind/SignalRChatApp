using Microsoft.AspNetCore.SignalR;

namespace HubServer.Hubs
{
    public class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.Caller.SendAsync("RecieveSystemMessage",
                $"Hi {Context.ConnectionId}!, you are connected!");
        }
    }
}

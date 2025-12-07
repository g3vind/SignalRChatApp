using Microsoft.AspNetCore.SignalR;

namespace HubServer.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            Console.WriteLine("A client connected to the ChatHub." + Context.ConnectionId);
            return base.OnConnectedAsync();
        }
    }
}

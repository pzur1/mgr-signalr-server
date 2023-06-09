using Microsoft.AspNetCore.SignalR;

namespace SignalR.Hubs
{
    public class ActivityHub : Hub
    {
        public async Task NewMessage(string username, string message) =>
            await Clients.All.SendAsync("ReceiveMessage", username, message);
    }
}

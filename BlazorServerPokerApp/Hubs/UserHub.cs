using BlazorServerPokerApp.Data;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerPokerApp.Hubs
{
    public class UserHub : Hub
    {
        public async Task SendMesage( User user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

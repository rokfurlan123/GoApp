using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace GoWebApp.Server.Hubs
{
    public class GoHub : Hub
    {
        [Authorize]
        public async Task SendMessage(string user, string message)
        {
            string userClaim = Context.User.FindFirst(ClaimTypes.Name).Value;
            string claim = Context.UserIdentifier;
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

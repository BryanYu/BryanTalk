using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CacheManager.Core;
using Microsoft.AspNetCore.SignalR;

namespace TalkServer.Hubs
{
    public class ChatHub : BaseHub<IChatClient>
    {
        public ChatHub(ICacheManager<string> cacheManager) : base(cacheManager)
        {
                    
        }
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.ReceiveMessage(user, message);
            
        }   
    }

    public interface IChatClient
    {
        Task ReceiveMessage(string user, string message);
        Task ReceiveMessage(string message);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CacheManager.Core;
using Microsoft.AspNetCore.SignalR;

namespace TalkServer.Hubs
{
    public class BaseHub<T> : Hub<T> where T : class
    {
        private readonly ICacheManager<string> _cacheManager;

        public BaseHub(ICacheManager<string> cacheManager)
        {
            _cacheManager = cacheManager;
        }
        public override async Task OnConnectedAsync()
        {   
            await base.OnConnectedAsync();
        }
    }
}

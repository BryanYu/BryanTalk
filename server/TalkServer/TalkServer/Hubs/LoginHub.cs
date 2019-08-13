using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CacheManager.Core;
using Microsoft.AspNetCore.SignalR;
using TalkServer.Hubs.Interfaces;

namespace TalkServer.Hubs
{
    public class LoginHub : BaseHub<ILoginHub>
    {
        public LoginHub(ICacheManager<string> cacheManager) : base(cacheManager)
        {
            
        }

        /// <summary>
        /// 登入(取token)
        /// </summary>
        /// <param name="account"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HubMethodName("Login")]
        public async Task LoginAsync(string account, string password)
        {
            //TODO : Login Business
            var token = string.Empty;
            await Clients.Caller.ReceiveLoginAsync(token);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.SignalR;
using TalkServer.Hubs;

namespace TalkServer.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
            
        }
        public void OnGet()
        {
        }
    }
}

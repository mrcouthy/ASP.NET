using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalRServer
{
    public class ClockHub : Hub
    {
        public override Task OnConnected()
        {
            Clients.All.showTime("Hello time");
            return base.OnConnected();
        }
       
    }
}

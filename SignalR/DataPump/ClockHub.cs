using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 using System.Timers;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalRServer
{
    public class ClockHub : Hub
    {
        private Timer _timer;
        public override Task OnConnected()
        {
            if (_timer ==null)
            {
                _timer = new Timer(1000);

                _timer.Elapsed += (s, e) =>
                {
                    Clients.All.showTime(DateTime.Now.ToString());
                };
                _timer.Start();
            }
            return base.OnConnected();
        }
       
    }
}

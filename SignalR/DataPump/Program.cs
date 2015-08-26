using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;

namespace DataPump
{
    class Program
    {
        static void Main(string[] args)
        {
            const string url = "http://localhost:8080/";
            using (WebApp.Start(url))
            {
                Console.WriteLine("Started server on {0}", url);
                Console.ReadLine();
                while (true)
                {
                    string message = Console.ReadLine();
                    var hub = GlobalHost.ConnectionManager.GetHubContext<ChatPump>();
                    hub.Clients.All.showAdminMessage("Admin", message);
                    Console.ReadLine();
                }
            }
        }
    }
}

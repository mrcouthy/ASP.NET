using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace DataPump
{
    public class ChatPump : Hub
    {
        public override Task OnConnected()
        {
            Clients.All.showAdminMessage("Admin", "Enjoy Chat Guys!");
            return base.OnConnected();
        }


        public void ShowAdminMessage( string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            //      Clients.User("Dhiraj").broadcastMessage(name, message);

           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRChat
{
    public class ChatHub : Hub
    {
        public void Send(string groupName,string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            //      Clients.User("Dhiraj").broadcastMessage(name, message);

            Clients.Group(groupName).broadcastMessage(name, message);
        }

        public void AddToGroup(string name)
        {
            Groups.Add(Context.ConnectionId, name);
        }
    }
}
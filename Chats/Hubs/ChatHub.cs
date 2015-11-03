using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Chats.Hubs
{
    public class ChatHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }
        public void Sendmessage(string name, string message) {
            //update alle clients
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}
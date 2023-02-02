using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIgnalE
{
    public class ChatHub : Hub
    {
        public void Send(string username, string message)
        {
            Clients.All.sendMessage(username, message);
        }
        //public void Report(string data)
        //{
        //    Clients.All.sendRepost(data);
        //}
    }
}
﻿using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SingnalRExample
{
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}
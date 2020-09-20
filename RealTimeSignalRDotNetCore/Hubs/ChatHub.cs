﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeSignalRDotNetCore.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string fromUser, string message)
        {
            await Clients.All.SendAsync("RecieveMessage", fromUser, message);

        }
    }
}

﻿using Microsoft.AspNetCore.SignalR;
using Rnwood.Smtp4dev.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rnwood.Smtp4dev.Hubs
{
    public class MessagesHub : Hub
    {
        public async Task OnMessageAdded()
        {
            await Clients.All.InvokeAsync("messageadded");
        }

        public async Task OnMessageRemoved()
        {
            await Clients.All.InvokeAsync("messageremoved");
        }
    }
}

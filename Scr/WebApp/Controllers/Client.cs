﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Controllers
{

    public class Client
    {
        public string Name { get; set; }
        public Client Opponent { get; set; }
        public bool IsPlaying { get; set; }
        public bool WaitingForMove { get; set; }
        public bool LookingForOpponent { get; set; }
        public DateTime GameStarted { get; set; }
        public string Simbolo { get; set; }

        public string ConnectionId { get; set; }
    }







}


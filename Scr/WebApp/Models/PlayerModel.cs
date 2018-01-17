using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public PlayerModel Opponent { get; set; }
        public bool IsPlaying { get; set; }
        public bool WaitingForMove { get; set; }
        public bool LookingForOpponent { get; set; }
        public DateTime GameStarted { get; set; }
        public string Simbolo { get; set; }

        public string ConnectionId { get; set; }
    }
}
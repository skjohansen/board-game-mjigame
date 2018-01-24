using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class PlayerModel
    {
        public string Symbol { get; set; }

        public PlayerModel()
        {
            string Symbol = "url(\"Pictures/X.png\")";
        }
    }
}
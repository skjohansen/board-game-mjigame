using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class GameBoard
    {
        public string[] Fields { get; set; }

        public GameBoard()
        {
            Fields = new string[9];
        }

    }
}
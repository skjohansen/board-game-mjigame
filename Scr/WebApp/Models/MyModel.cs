using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class MyModel
    {
        public GameEngine.Player Player { get; set; }
        

        

        public MyModel()
        {
            Player = new GameEngine.Player();
        }
    }
}
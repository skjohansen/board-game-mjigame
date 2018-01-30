using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameEngine
{
    public class Player
    {
        public string Name;
        public string ID { get; set; }
        public string Symbol { get; set; }
        public int Wins { get; set; }
        public string Email { get; set; }


        public Player(string name, string id, string email)
        {
            Name = name;
            ID = id;
            Wins = 0;
            Email = email;
        }
    }



}

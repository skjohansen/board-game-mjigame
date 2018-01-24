using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class TicTacToe
    {
        public List<Player> Players { get; set; }


        // skall innehålla all spel logik
        public void JoinGame(Player player)
        {
            if(Players == null)
            {
                Players = new List<Player>();
            }
            Players.Add(player);
        }
        public void MakeMove()
        {

        }
    }
}

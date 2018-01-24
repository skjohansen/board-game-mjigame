using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class TicTacToe
    {
        public List<Player> Players { get; set; } = new List<Player>();
        public GameBoard GameBoard { get; set; }
        public Player ActivePlayer { get; set; }


        // skall innehålla all spel logik
        public void JoinGame(Player player)
        { 
            Players.Add(player);
        }
        public void MakeMove(Player player)
        {

        }
        public void CheckWinner()
        {

        }
        public void CheckTie()
        {

        }


    }
}

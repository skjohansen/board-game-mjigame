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
        public string Result { get; set; }
        public int Ties { get; set; }


        // skall innehålla all spel logik
        public void JoinGame(Player player)
        {
            Players.Add(player);
        }
        public void MakeMove(Player player, string fieldId)
        {
        }
        public string CheckWinner()
        {
            Result = "Waiting for winner";
            for (int i = 0; i < GameBoard.Fields.Count; i++)
            {
                if (GameBoard.Fields[0] == "red" && GameBoard.Fields[1] == "red" && GameBoard.Fields[2] == "red")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[3] == "red" && GameBoard.Fields[4] == "red" && GameBoard.Fields[5] == "red")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[6] == "red" && GameBoard.Fields[7] == "red" && GameBoard.Fields[8] == "red")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[0] == "red" && GameBoard.Fields[3] == "red" && GameBoard.Fields[6] == "red")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[1] == "red" && GameBoard.Fields[4] == "red" && GameBoard.Fields[7] == "red")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[2] == "red" && GameBoard.Fields[5] == "red" && GameBoard.Fields[8] == "red")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[0] == "red" && GameBoard.Fields[4] == "red" && GameBoard.Fields[8] == "red")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[2] == "red" && GameBoard.Fields[4] == "red" && GameBoard.Fields[6] == "red")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }

                if (GameBoard.Fields[0] == "blue" && GameBoard.Fields[1] == "blue" && GameBoard.Fields[2] == "blue")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[3] == "blue" && GameBoard.Fields[4] == "blue" && GameBoard.Fields[5] == "blue")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[6] == "blue" && GameBoard.Fields[7] == "blue" && GameBoard.Fields[8] == "blue")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[0] == "blue" && GameBoard.Fields[3] == "blue" && GameBoard.Fields[6] == "blue")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[1] == "blue" && GameBoard.Fields[4] == "blue" && GameBoard.Fields[7] == "blue")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[2] == "blue" && GameBoard.Fields[5] == "blue" && GameBoard.Fields[8] == "blue")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[0] == "blue" && GameBoard.Fields[4] == "blue" && GameBoard.Fields[8] == "blue")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[2] == "blue" && GameBoard.Fields[4] == "blue" && GameBoard.Fields[6] == "blue")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }

            }

            return Result;

        }
        
        // Constructor

    }
}


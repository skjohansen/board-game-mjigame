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
                if (GameBoard.Fields[0] == "X.png" && GameBoard.Fields[1] == "X.png" && GameBoard.Fields[2] == "X.png")
                {
                    Result = "The wwinner is " + Players[0].Name;
                    Players[0].Wins++;
                }
                else if (GameBoard.Fields[3] == "X.png" && GameBoard.Fields[4] == "X.png" && GameBoard.Fields[5] == "X.png")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[6] == "X.png" && GameBoard.Fields[7] == "X.png" && GameBoard.Fields[8] == "X.png")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[0] == "X.png" && GameBoard.Fields[3] == "X.png" && GameBoard.Fields[6] == "X.png")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[1] == "X.png" && GameBoard.Fields[4] == "X.png" && GameBoard.Fields[7] == "X.png")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[2] == "X.png" && GameBoard.Fields[5] == "X.png" && GameBoard.Fields[8] == "X.png")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[0] == "X.png" && GameBoard.Fields[4] == "X.png" && GameBoard.Fields[8] == "X.png")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }
                else if (GameBoard.Fields[2] == "X.png" && GameBoard.Fields[4] == "X.png" && GameBoard.Fields[6] == "X.png")
                {
                    Result = "The wwinner is " + Players[0].Name;
                }

                if (GameBoard.Fields[0] == "O.png" && GameBoard.Fields[1] == "O.png" && GameBoard.Fields[2] == "O.png")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[3] == "O.png" && GameBoard.Fields[4] == "O.png" && GameBoard.Fields[5] == "O.png")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[6] == "O.png" && GameBoard.Fields[7] == "O.png" && GameBoard.Fields[8] == "O.png")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[0] == "O.png" && GameBoard.Fields[3] == "O.png" && GameBoard.Fields[6] == "O.png")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[1] == "O.png" && GameBoard.Fields[4] == "O.png" && GameBoard.Fields[7] == "O.png")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[2] == "O.png" && GameBoard.Fields[5] == "O.png" && GameBoard.Fields[8] == "O.png")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[0] == "O.png" && GameBoard.Fields[4] == "O.png" && GameBoard.Fields[8] == "O.png")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }
                else if (GameBoard.Fields[2] == "O.png" && GameBoard.Fields[4] == "O.png" && GameBoard.Fields[6] == "O.png")
                {
                    Result = "The wwinner is " + Players[1].Name;
                }

            }

            return Result;

        }
        
        // Constructor

    }
}


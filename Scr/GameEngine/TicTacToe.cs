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
        public Player Winner { get; set; }
        public int Ties { get; set; }



        // All spel-logic ska vara här
        public void JoinGame(Player player)
        {
            Players.Add(player);
        }
        public void MakeMove(string fieldId)
        {
            for (int i = 0; i < GameBoard.Fields.Count; i++)
            {
                if (i == int.Parse(fieldId))
                {
                    if (GameBoard.Fields[int.Parse(fieldId)] == "W.png")
                    {
                        GameBoard.Fields[i] = ActivePlayer.Color;
                        CheckWinner();
                        if (Winner == ActivePlayer)
                        {

                        }
                        TogglePlayer();
                    }
                }
            }
        }

        public void CheckWinner()
        {


            for (int i = 0; i < GameBoard.Fields.Count; i++)
            {

                // Check if Player 1 won the game
                if (GameBoard.Fields[0] == "X.png" && GameBoard.Fields[1] == "X.png" && GameBoard.Fields[2] == "X.png")
                {
                    Winner = Players[0];
                    RestartGame();
                }
                else if (GameBoard.Fields[3] == "X.png" && GameBoard.Fields[4] == "X.png" && GameBoard.Fields[5] == "X.png")
                {
                    Winner = Players[0];
                }
                else if (GameBoard.Fields[6] == "X.png" && GameBoard.Fields[7] == "X.png" && GameBoard.Fields[8] == "X.png")
                {
                    Winner = Players[0];
                }
                else if (GameBoard.Fields[0] == "X.png" && GameBoard.Fields[3] == "X.png" && GameBoard.Fields[6] == "X.png")
                {
                    Winner = Players[0];
                }
                else if (GameBoard.Fields[1] == "X.png" && GameBoard.Fields[4] == "X.png" && GameBoard.Fields[7] == "X.png")
                {
                    Winner = Players[0];
                }
                else if (GameBoard.Fields[2] == "X.png" && GameBoard.Fields[5] == "X.png" && GameBoard.Fields[8] == "X.png")
                {
                    Winner = Players[0];
                }
                else if (GameBoard.Fields[0] == "X.png" && GameBoard.Fields[4] == "X.png" && GameBoard.Fields[8] == "X.png")
                {
                    Winner = Players[0];
                }
                else if (GameBoard.Fields[2] == "X.png" && GameBoard.Fields[4] == "X.png" && GameBoard.Fields[6] == "X.png")
                {
                    Winner = Players[0];
                }

                // Check if Player 2 won the game
                if (GameBoard.Fields[0] == "O.png" && GameBoard.Fields[1] == "O.png" && GameBoard.Fields[2] == "O.png")
                {
                    Winner = Players[1];
                }
                else if (GameBoard.Fields[3] == "O.png" && GameBoard.Fields[4] == "O.png" && GameBoard.Fields[5] == "O.png")
                {
                    Winner = Players[1];
                }
                else if (GameBoard.Fields[6] == "O.png" && GameBoard.Fields[7] == "O.png" && GameBoard.Fields[8] == "O.png")
                {
                    Winner = Players[1];
                }
                else if (GameBoard.Fields[0] == "O.png" && GameBoard.Fields[3] == "O.png" && GameBoard.Fields[6] == "O.png")
                {
                    Winner = Players[1];
                }
                else if (GameBoard.Fields[1] == "O.png" && GameBoard.Fields[4] == "O.png" && GameBoard.Fields[7] == "O.png")
                {
                    Winner = Players[1];
                }
                else if (GameBoard.Fields[2] == "O.png" && GameBoard.Fields[5] == "O.png" && GameBoard.Fields[8] == "O.png")
                {
                    Winner = Players[1];
                }
                else if (GameBoard.Fields[0] == "O.png" && GameBoard.Fields[4] == "O.png" && GameBoard.Fields[8] == "O.png")
                {
                    Winner = Players[1];
                }
                else if (GameBoard.Fields[2] == "O.png" && GameBoard.Fields[4] == "O.png" && GameBoard.Fields[6] == "O.png")
                {
                    Winner = Players[1];
                }

            }
        }
        public void AddWins()
        {
            if (Winner == ActivePlayer)
            {
                ActivePlayer.Wins++;
                Winner = null;
            }
        }
        public void TogglePlayer()
        {
            if (ActivePlayer.ID == Players[0].ID)
            {
                ActivePlayer = Players[1];
            }
            else
            {
                ActivePlayer = Players[0];
            }
        }

        public TicTacToe()
        {
          
        }
        public void RestartGame()
        {
            for (int i = 0; i < GameBoard.Fields.Count; i++)
            {
                GameBoard.Fields[i] = "W.png";
                ActivePlayer = Players[1];
            }
        }

    }
}


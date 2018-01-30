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
        public GameBoard GameBoard { get; set; }
        public Player ActivePlayer { get; set; }
        public GameInformation GameInformation { get; set; }

        public TicTacToe()
        {
            Players = new List<Player>();
            GameBoard = new GameBoard();
            ActivePlayer = null;
            GameInformation = new GameInformation();
        }

       
        public void JoinGame(string userName, string sessionID)
        {
            if (Players.Count == 0)
            {
                Players.Add(new Player(userName, sessionID));
                Players[0].Color = "X.png";
                ActivePlayer = Players[0];
            }
            else if (Players.Count == 1)
            {
                Players.Add(new Player(userName, sessionID));
                Players[1].Color = "O.png";
            }
            else
            {
                throw new ArgumentException("Game is full");
            }

        }
        public void MakeMove(string fieldID)
        {
            int field = int.Parse(fieldID);

            for (int i = 0; i < GameBoard.Fields.Count; i++)
            {
                if (i == field)
                {
                    if (GameBoard.Fields[field] == "W.png")
                    {
                        GameBoard.Fields[i] = ActivePlayer.Color;
                    }
                }
            }
        }

        public bool CheckIfGameIsOver(Player p)
        {

            for (int i = 0; i < GameBoard.Fields.Count; i++)
            {

                if ((GameBoard.Fields[0] == p.Color && GameBoard.Fields[1] == p.Color && GameBoard.Fields[2] == p.Color) || (GameBoard.Fields[3] == p.Color && GameBoard.Fields[4] == p.Color && GameBoard.Fields[5] == p.Color)
                    || (GameBoard.Fields[6] == p.Color && GameBoard.Fields[7] == p.Color && GameBoard.Fields[8] == p.Color) || (GameBoard.Fields[0] == p.Color && GameBoard.Fields[3] == p.Color && GameBoard.Fields[6] == p.Color)
                    || (GameBoard.Fields[1] == p.Color && GameBoard.Fields[4] == p.Color && GameBoard.Fields[7] == p.Color) || (GameBoard.Fields[2] == p.Color && GameBoard.Fields[5] == p.Color && GameBoard.Fields[8] == p.Color)
                    || (GameBoard.Fields[0] == p.Color && GameBoard.Fields[4] == p.Color && GameBoard.Fields[8] == p.Color) || (GameBoard.Fields[2] == p.Color && GameBoard.Fields[4] == p.Color && GameBoard.Fields[6] == p.Color))
                {
                    p.Wins += 1;
                    GameInformation.GameOverMessage = "Contratulations " + p.Name + "!";
                    return true;
                }

                else if (!GameBoard.Fields.Contains("W.png"))
                {
                    GameInformation.GameOverMessage = "Det blev lika!";
                    GameInformation.Ties += 1;
                    return true;
                }

            }

            return false;

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
        public void ResetGameBoard()
        {
            for (int i = 0; i < GameBoard.Fields.Count; i++)
            {
                GameBoard.Fields[i] = "W.png";
            }
        }

    }
}





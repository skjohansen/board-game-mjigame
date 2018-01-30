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


        public void JoinGame(string userName, string sessionID, string email)
        {

            if (Players.Count == 0)
            {
                Players.Add(new Player(userName, sessionID, email));
                Players[0].Symbol = "X.png";
                ActivePlayer = Players[0];
            }
            else if (Players.Count == 1)
            {
                Players.Add(new Player(userName, sessionID, email));
                Players[1].Symbol = "O.png";
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
                    if (GameBoard.Fields[field] == "empty.png")
                    {
                        GameBoard.Fields[i] = ActivePlayer.Symbol;
                    }
                }
            }
        }

        public bool CheckIfGameIsOver(Player p)
        {

            for (int i = 0; i < GameBoard.Fields.Count; i++)
            {

                if ((GameBoard.Fields[0] == p.Symbol && GameBoard.Fields[1] == p.Symbol && GameBoard.Fields[2] == p.Symbol) || (GameBoard.Fields[3] == p.Symbol && GameBoard.Fields[4] == p.Symbol && GameBoard.Fields[5] == p.Symbol)
                    || (GameBoard.Fields[6] == p.Symbol && GameBoard.Fields[7] == p.Symbol && GameBoard.Fields[8] == p.Symbol) || (GameBoard.Fields[0] == p.Symbol && GameBoard.Fields[3] == p.Symbol && GameBoard.Fields[6] == p.Symbol)
                    || (GameBoard.Fields[1] == p.Symbol && GameBoard.Fields[4] == p.Symbol && GameBoard.Fields[7] == p.Symbol) || (GameBoard.Fields[2] == p.Symbol && GameBoard.Fields[5] == p.Symbol && GameBoard.Fields[8] == p.Symbol)
                    || (GameBoard.Fields[0] == p.Symbol && GameBoard.Fields[4] == p.Symbol && GameBoard.Fields[8] == p.Symbol) || (GameBoard.Fields[2] == p.Symbol && GameBoard.Fields[4] == p.Symbol && GameBoard.Fields[6] == p.Symbol))
                {
                    p.Wins += 1;
                    GameInformation.GameOverMessage = "Congratulations " + p.Name + "!";
                    return true;
                }

                else if (!GameBoard.Fields.Contains("empty.png"))
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
                GameBoard.Fields[i] = "empty.png";
            }
        }
        public void SetDisplayName(string sessionID)
        {
            if (sessionID == Players[0].ID)
            {
               
                GameInformation.DisplayName = Players[0].Name + " You are playing as:" + " [ " + Players[0].Symbol[0] + " ]";
            }
            else if (sessionID == Players[1].ID)
            {
                GameInformation.DisplayName = Players[1].Name + " You are playing as:" + " [ " + Players[1].Symbol[0] + " ]";
            }
        }
    }
}





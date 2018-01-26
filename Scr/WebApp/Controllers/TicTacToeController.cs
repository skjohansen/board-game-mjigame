using GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameEngine;
namespace WebApp.Controllers
{
    public class TicTacToeController : Controller
    {
        private static TicTacToe ticTacToeGame;

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult PreGame(string userName)
        {

            if (ticTacToeGame == null)
            {
                ticTacToeGame = new TicTacToe();
            }

            Session["aa"] = "ok";
            string sessionID = Session.SessionID;

            if (ticTacToeGame.Players.Count == 0)
            {
                ticTacToeGame.JoinGame(new Player() { Name = userName, ID = sessionID, Color = "X.png" });
            }

            else if (ticTacToeGame.Players.Count == 1)
            {
                ticTacToeGame.JoinGame(new Player() { Name = userName, ID = sessionID, Color = "O.png" });
            }

            else { return View("Login"); }

            if (ticTacToeGame.ActivePlayer == null)
            {
                ticTacToeGame.ActivePlayer = ticTacToeGame.Players[0];
            }

            return RedirectToAction("Game", "TicTacToe");

        }

        public ActionResult Game(string fieldId)
        {

            if (ticTacToeGame.GameBoard == null)
            {
                ticTacToeGame.GameBoard = new GameBoard();
            }

            if (ticTacToeGame.Players.Count > 1)
            {
                if (ticTacToeGame.ActivePlayer.ID == Session.SessionID)
                {
                    if (fieldId != null)
                    {
                        ticTacToeGame.MakeMove(fieldId);
                        ticTacToeGame.CheckWinner();
                        ticTacToeGame.AddWins();
                    }
                }
            }
            return View(ticTacToeGame);
        }


    }
}











//private void TogglePlayer()
//{

//}

//                        for (int i = 0; i<ticTacToeGame.GameBoard.Fields.Count; i++)
//                        {
//                            if (i == int.Parse(fieldId))
//                            {
//                                if (ticTacToeGame.GameBoard.Fields[int.Parse(fieldId)] == "W.png")
//                                {
//                                    ticTacToeGame.GameBoard.Fields[i] = ticTacToeGame.ActivePlayer.Color;
//                                    TogglePlayer();
//ticTacToeGame.CheckWinner();
//                                    if (ticTacToeGame.CheckWinner() == "The winner is " + ticTacToeGame.ActivePlayer.Name)
//                                    {
//                                        ticTacToeGame.ActivePlayer.Wins++;
//                                    }
//                                }
//                            }
//                        }
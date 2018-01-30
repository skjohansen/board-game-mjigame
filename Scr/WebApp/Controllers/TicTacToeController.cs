using GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
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

            Session["what"] = "ever";
            string sessionID = Session.SessionID;

            try
            {
                ticTacToeGame.JoinGame(userName, sessionID);
            }

            catch
            {
                ViewBag.GameIsFullMessage = "Game is full, please try later";
                return View( "Login" );
            }

            return RedirectToAction("Game", "TicTacToe");

        }

        public ActionResult Game(string fieldID)
        {
            ticTacToeGame.SetDisplayName(Session.SessionID);

            if (fieldID == null || ticTacToeGame.Players.Count < 2 || ticTacToeGame.ActivePlayer.ID != Session.SessionID)
            {
                return View(ticTacToeGame);
            }

            else
            {
                ticTacToeGame.MakeMove(fieldID);

                if (ticTacToeGame.CheckIfGameIsOver(ticTacToeGame.ActivePlayer))
                {
                    ticTacToeGame.ResetGameBoard();
                    ticTacToeGame.TogglePlayer();
                    return View("GameOver", ticTacToeGame);
                }

                ticTacToeGame.TogglePlayer();
                return View(ticTacToeGame);
            }

        }

        public ActionResult GameOver()
        {
            return View();
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
//                                    ticTacToeGame.GameBoard.Fields[i] = ticTacToeGame.ActivePlayer.Symbol;
//                                    TogglePlayer();
//ticTacToeGame.CheckWinner();
//                                    if (ticTacToeGame.CheckWinner() == "The winner is " + ticTacToeGame.ActivePlayer.Name)
//                                    {
//                                        ticTacToeGame.ActivePlayer.Wins++;
//                                    }
//                                }
//                            }
//                        }
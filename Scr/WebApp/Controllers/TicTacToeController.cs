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
            // Skapa ett nytt game om det inte redan finns ett
            if (ticTacToeGame == null)
            {
                ticTacToeGame = new TicTacToe();
            }

            Session["what"] = "ever";
            string sessionID = Session.SessionID;

            if (ticTacToeGame.Players[0].ID == null)
            {
                ticTacToeGame.Players[0].Name = userName;
                ticTacToeGame.Players[0].ID = sessionID;
                ticTacToeGame.Players[0].Color = "X.png";
            }

            else if (ticTacToeGame.Players[1].ID == null)
            {
                ticTacToeGame.Players[1].Name = userName;
                ticTacToeGame.Players[1].ID = sessionID;
                ticTacToeGame.Players[1].Color = "O.png";
            }

            else { return View("Login"); }

            return RedirectToAction("Game", "TicTacToe");

        }

        public ActionResult Game(string fieldId)
        {

            if (ticTacToeGame.Players[1].ID == null)
            {
                ticTacToeGame.ActivePlayer = ticTacToeGame.Players[0];
            }


            // Om det finns 2 spelare i spelet så kan den aktiva spelaren göra ett move
            if (fieldId != null)
            {
                if (ticTacToeGame.Players.Count > 1)
                {
                    if (ticTacToeGame.ActivePlayer.ID == Session.SessionID)
                    {
                        ticTacToeGame.MakeMove(fieldId);
                        if (ticTacToeGame.CheckWinner())
                        {
                            foreach (Player x in ticTacToeGame.Players)
                            {
                                if (ticTacToeGame.ActivePlayer != x)
                                {
                                    x.Wins++;
                                    ticTacToeGame.ResetGameBoard();
                                    return View("GameOver", ticTacToeGame);
                                }
                            }
                        }
                        if (ticTacToeGame.CheckTie())
                        {
                            ticTacToeGame.ResetGameBoard();
                            ticTacToeGame.Ties += 1;
                            return View("GameOver", ticTacToeGame);
                        }
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
﻿using GameEngine;
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

        public ActionResult PreGame(string userName, string email)
        {

            if (ticTacToeGame == null)
            {
                ticTacToeGame = new TicTacToe();
            }

            Session["what"] = "ever";
            string sessionID = Session.SessionID;

            try
            {
                ticTacToeGame.JoinGame(userName, sessionID, email);
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
                try
                {
                    ticTacToeGame.MakeMove(fieldID);
                }
                catch
                {
                    return View(ticTacToeGame);
                }

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
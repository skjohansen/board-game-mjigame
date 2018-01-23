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

        public ActionResult Game(string UserName)
        {
            if (ticTacToeGame == null){
                ticTacToeGame = new TicTacToe();
            }
            ticTacToeGame.JoinGame(new Player() { name = UserName });

            // send playernames to view
            if (ticTacToeGame.Players.Count >= 1) {
                ViewBag.Player1 = ticTacToeGame.Players[0].name;
            }
            if (ticTacToeGame.Players.Count >= 2)
            {
                ViewBag.Player2 = ticTacToeGame.Players[1].name;
            }

            return View();
        }



    }
}
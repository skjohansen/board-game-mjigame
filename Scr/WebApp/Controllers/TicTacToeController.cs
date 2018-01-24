using GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

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
            ticTacToeGame.JoinGame(new Player() { Name = userName });
            return RedirectToAction("Game", "TicTacToe");

        }

        public ActionResult Game()
        {
            try
            {
                if (ticTacToeGame.Players.Count >= 1)
                {
                    ViewBag.Player1 = ticTacToeGame.Players[0].Name;
                }
            }

            catch
            {
                return RedirectToAction("Login", "TicTacToe");
            }

            if (ticTacToeGame.Players.Count >= 2)
            {
                ViewBag.Player2 = ticTacToeGame.Players[1].Name;
            }

            //GameBoard gb = new GameBoard();
            

            //for (int i = 0; i < 9; i++)
            //{
            //    gb.Fields[i] = "red";
            //}

            //for (int i = 0; i < gb.Fields.Length;)
            //{

            //}
            //if (fieldID != null)
            //{
            //    gb.Fields[int.Parse(fieldID)] = playah.Symbol;
            //}

            return View();
        }

        public ActionResult Move(string fieldID)
        {
            PlayerModel playah = new PlayerModel();
            return View(playah);
        }
    }
}
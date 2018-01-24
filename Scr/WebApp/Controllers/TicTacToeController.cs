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


        public ActionResult PreGame(string userName) { 
        
            if (ticTacToeGame == null){
                ticTacToeGame = new TicTacToe();
            }
            Session["player"] = "playing";
            string sessionID = Session.SessionID;

            ticTacToeGame.JoinGame(new Player() { Name = userName, ID = sessionID  });
            return RedirectToAction("Game", "TicTacToe");

            }

    

        public ActionResult Game(string fieldId)
        {

            if (ticTacToeGame.Players.Count >= 1) {
                ViewBag.Player1 = ticTacToeGame.Players[0].Name;
            }

            if (ticTacToeGame.Players.Count >= 2)
            {
                ViewBag.Player2 = ticTacToeGame.Players[1].Name;
            }

            Gameboard gb = new Gameboard();
            gb.FieldColor = new string[9];

            //for (int i = 0; i < 9; i++)
            //{
            //    gb.FieldColor[i] = "red";
            //}

            //if (fieldId != null)
            //{
            //    gb.FieldColor[int.Parse(fieldId)] = "blue";
            //}


            return View(gb);
        }




    }
}
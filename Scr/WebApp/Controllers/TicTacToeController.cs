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
        
            if (ticTacToeGame == null){
                ticTacToeGame = new TicTacToe();
            }
            Session["player"] = "playing";
            string sessionID = Session.SessionID;

            ticTacToeGame.JoinGame(new Player() { Name = userName, ID = sessionID  });
            //ticTacToeGame.JoinGame(new Player() { Name = userName + "2", ID = sessionID + "2" });
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
                ticTacToeGame.GameBoard.Fields = new List<string>();
                ticTacToeGame.GameBoard.Fields.Add("white");
                ticTacToeGame.GameBoard.Fields.Add("white");
                ticTacToeGame.GameBoard.Fields.Add("white");
                ticTacToeGame.GameBoard.Fields.Add("white");
                ticTacToeGame.GameBoard.Fields.Add("white");
                ticTacToeGame.GameBoard.Fields.Add("white");
                ticTacToeGame.GameBoard.Fields.Add("white");
                ticTacToeGame.GameBoard.Fields.Add("white");
                ticTacToeGame.GameBoard.Fields.Add("white");
                ticTacToeGame.GameBoard.Fields.Add("white");


                ticTacToeGame.Players[0].Symbol = "red";
                //ticTacToeGame.Players[1].Symbol = "blue";
            }


            if (ticTacToeGame.ActivePlayer.ID == Session.SessionID) {

                if (fieldId != null)
                {
                    for (int i = 0; i < ticTacToeGame.GameBoard.Fields.Count; i++)
                    {
                        if (i == int.Parse(fieldId))
                        {
                            if(ticTacToeGame.GameBoard.Fields[int.Parse(fieldId)] == "white")
                            {
                                ticTacToeGame.GameBoard.Fields[i] = ticTacToeGame.ActivePlayer.Symbol;
                                TogglePlayer();
                            }
                        }
                    }
                }
            }

            return View(ticTacToeGame);
        }

        private void TogglePlayer()
        {
            if (ticTacToeGame.ActivePlayer.ID == ticTacToeGame.Players[0].ID)
            {
                ticTacToeGame.ActivePlayer = ticTacToeGame.Players[1];
            }
            else
            {
                ticTacToeGame.ActivePlayer = ticTacToeGame.Players[0];

            }
        }




    }
}
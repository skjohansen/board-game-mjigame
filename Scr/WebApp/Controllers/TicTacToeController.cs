using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class TicTacToeController : Controller
    {
        
        public ActionResult Index()
        {
            MyModel test = new MyModel();
            Session.Add("gameId", 3);
            return View(test);
        }

        // /Default/StartGame?nickname=Nickckkke
        public ActionResult StartGame(string nickname)
        {
            return View();
        }

        public ActionResult Page2()
        {
            
            return View(Session["nickname"]);
        }

        public ActionResult Ludo()
        {
            return View();

            // create a view which have an input, <input type="text" name="Nickname" /> and a button eg "Start game"
            // when clicking the button access the controller StartGame with the parameter nickname
            // save the result in a session variable, eg. Session["nickname] = value of input
            // show the nickname on StartGame view
            // on View2 which shows the content of Session["nickname"]
        }
    }
}
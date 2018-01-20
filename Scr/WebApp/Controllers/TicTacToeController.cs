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

        //public ActionResult Index()
        //{
        //    Session.Add("gameId", 3);
        //    return View();
        //}


        //////        public ActionResult Index()
        //////        {
        //////<<<<<<< HEAD
        //////            HttpCookie cookie = new HttpCookie("playerID");
        //////            cookie.Value = "success";
        //////            Response.SetCookie(cookie);

        //////=======
        //////            ViewData["Message"] = "Welcome to ASP.NET MVC!";
        //////            string cookie = "There is no cookie!";
        //////            if (this.ControllerContext.HttpContext.Request.Cookies.AllKeys.Contains("Cookie"))
        //////            {
        //////                cookie = "Yeah - Cookie: " + this.ControllerContext.HttpContext.Request.Cookies["Cookie"].Value;
        //////            }
        //////            ViewData["Cookie"] = cookie;
        //////            return View();
        //////        }






        //        // /Default/StartGame?nickname=Nickckkke
        //        public ActionResult StartGame(string nickname)
        //        {
        //            return View();
        //        }
        //>>>>>>> 9cd43f28d1be0b1caed8a68d48a9f444bf54a08e

        //            return View();
        //        }
        //Session.Add("gameId", 3);
        // /Default/StartGame?nickname=Nickckkke

        // create a view which have an input, <input type="text" name="Nickname" /> and a button eg "Start game"
        // when clicking the button access the controller StartGame with the parameter nickname
        // save the result in a session variable, eg. Session["nickname] = value of input
        // show the nickname on StartGame view
        // on View2 which shows the content of Session["nickname"]
        //string testString = Request.Cookies.Get("playerID").Value;

        //PlayerModel player = new PlayerModel();


        public ActionResult Index()
        {
            
            return View();
        }
        public ActionResult ClientInformation()
        {
            return View();
        }

        public ActionResult GetUsername(string username)
        {
            PlayerModel player = new PlayerModel();
            player.Name = username;
            return View(player);
        }



    }
}
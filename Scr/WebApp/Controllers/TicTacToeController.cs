﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class TicTacToeController : Controller
    {
        

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Game(string UserName)
        {
            return View();
        }


    }
}
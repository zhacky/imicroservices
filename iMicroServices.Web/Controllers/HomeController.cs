﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMicroServices.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your company description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "iMicro Services INC.";

            return View();
        }
    }
}
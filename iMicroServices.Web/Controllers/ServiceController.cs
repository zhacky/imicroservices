using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iMicroServices.Web.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult HelpDesk()
        {
            return View();
        }
    }
}
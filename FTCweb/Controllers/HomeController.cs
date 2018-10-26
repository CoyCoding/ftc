using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FTCweb.Models;

namespace FTCweb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            var csv = new WebConnection();

            //csv.GetString();
            var games = csv.GameList;

            ViewBag.Message = "Your application description page.";

            return View(games);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
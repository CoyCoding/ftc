using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FTCweb.Models;
using FTCweb.ViewModels;

namespace FTCweb.Controllers
{
    public class HomeController : Controller
    {
        private WebConnection _sheet;

        public HomeController()
        {
            _sheet = new WebConnection();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Main()
        {
            var gameList = new GameListViewModel
            {
                GameList = _sheet.GameList
                
            };

            return View(gameList);
        }
    }
}
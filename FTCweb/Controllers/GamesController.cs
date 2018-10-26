using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FTCweb.Models;

namespace FTCweb.Controllers
{
    public class GamesController : Controller
    {
        private WebConnection _sheet;

        public GamesController()
        {
            _sheet = new WebConnection();
        }

        // GET: Games
        public ActionResult Index()
        {
                var games = _sheet.GameList;

            return View(games);
        }
    }
}
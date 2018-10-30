using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FTCweb.Models;
using FTCweb.ViewModels;

namespace FTCweb.Controllers
{
    [RoutePrefix("Games")]
    public class GamesController : Controller
    {
        private WebConnection _sheet;

        public GamesController()
        {
            _sheet = new WebConnection();
        }

        // GET: Games
        [Route("SnesChallenge")]
        public ActionResult SnesChallenge()
        {
            var gameList = new GameListViewModel
            {
                GameList = _sheet.GameList
            };

            return View(gameList);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FTCweb.Models;
using FTCweb.ViewModels;

namespace FTCweb.Controllers.Api
{
    public class GamesController : ApiController
    {
        private WebConnection _sheet;

        public GamesController()
        {
            _sheet = new WebConnection();
        }

        //GET api/Games
        public IHttpActionResult GetGames(string query = null)
        {
            var gameList = new GameListViewModel
            {
                GameList = _sheet.GameList
            };

            return Ok(gameList);
        }
    }
}

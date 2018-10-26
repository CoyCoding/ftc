using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FTCweb.Models;

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
            var games = _sheet.GameList;

            return Ok(games);
        }
    }
}

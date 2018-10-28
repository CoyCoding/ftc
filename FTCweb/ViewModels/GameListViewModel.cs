using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FTCweb.Models;

namespace FTCweb.ViewModels
{
    public class GameListViewModel
    {
        public List<Game> GameList { get; set; }

        public int TotalGames()
        {
            return GameList.Count();
        }

        public int TotalGames(string genre)
        {
            return GameList.SelectedGenreList(genre).Count();
        }

        public int CompletedGames()
        {
            return GameList.CompletedGamesCount();
        }

        public int CompletedGames(string selectedGenre)
        {
            return GameList.SelectedGenreList(selectedGenre).CompletedGamesCount();
        }

        public string GetRandomBoxArt()
        {
            var rnd = new Random();
            int index = rnd.Next(1, TotalGames());
            return GameList[index].BoxArt;
        }
    }
}
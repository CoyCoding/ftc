using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FTCweb.Models;

namespace FTCweb.ViewModels
{
    public class GameListViewModel
    {
        private static Random rnd;

        static GameListViewModel()
        {
            rnd = new Random();
        }

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

        public Game GetRandomGame()
        {
            int index = rnd.Next(0, TotalGames());
            return GameList[index];
        }
    }
}
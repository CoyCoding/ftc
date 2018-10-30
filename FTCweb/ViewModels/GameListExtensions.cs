using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FTCweb.Models;

namespace FTCweb.ViewModels
{
    public static class GameListExtensions
    {
        public static int CompletedGamesCount(this IEnumerable<Game> list)
        {
            return list.Count(g => (g.Finished.Trim().Length != 0));
        }

        public static IEnumerable<Game> SelectedGenreList(this IEnumerable<Game> list, string genre)
        {
            return list.Where(g => g.Genre.Trim().ToUpper() == genre.Trim().ToUpper());
            
        }

    }
}
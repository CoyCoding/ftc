using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using FileHelpers;

namespace FTCweb.Models
{
    public class WebConnection
    {
        private FileHelperEngine<Game> Parser;
        private string _file;

        public List<Game> GameList { get; set; }


        public WebConnection()
        {
            using (var client = new WebClient())
            { 
               this._file = client.DownloadString("https://docs.google.com/spreadsheets/d/e/2PACX-1vQFyeOQ25jj2wkAQRES6VaC8wMNfmq8j9DYSL4aY_irMyxHq0b7q4xDy0UOjCA_gqjKfeDxYcKuEJfC/pub?output=csv");
            }

            ConvertFile();
        }

        public string GetString()
        {
            return _file;
        }

        private void ConvertFile()
        {
            Parser = new FileHelperEngine<Game>();
            var testobject = Parser.ReadString(_file).ToList();
            GameList = testobject;
        }


    }
}
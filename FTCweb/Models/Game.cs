using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using FileHelpers;

namespace FTCweb.Models
{
    [DelimitedRecord(",")]
    public class Game
    {

        [FieldOptional]
        [FieldOrder(1)]
        public string Finished{ get; set; }

        [FieldOptional]
        [FieldQuoted]
        [FieldOrder(2)]
        public string Title{ get; set; }

        [FieldOptional]
        [FieldOrder(3)]
        public string Genre{ get; set; }

        [FieldOptional]
        [FieldOrder(4)]
        public string Difficulty{ get; set; }

        [FieldOptional]
        [FieldOrder(5)]
        public string Thoughts{ get; set; }

        [FieldOptional]
        [FieldOrder(6)]
        public string Runtime{ get; set; }

        [FieldOptional]
        [FieldQuoted]
        [FieldOrder(7)]
        public string VideoLink{ get; set; }

        [FieldHidden]
        public string BoxArt
        {
            get
            {
                var imgTitle = Regex.Replace(Title, ":|&", "");
                return "<a href =\"/Content/img/SnesCover/" + imgTitle + " (USA).png\"><img src=\"/Content/img/SnesCover/"+ imgTitle +" (USA).png\"/></a>";
            }
        }
    }
}
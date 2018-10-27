using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileHelpers;

namespace FTCweb.Models
{
    [DelimitedRecord(",")]
    public class Game
    {
        [FieldOptional]
        public string Finished{ get; set; }
        [FieldOptional]
        [FieldQuoted]
        public string Title{ get; set; }
        [FieldOptional]
        public string Genre{ get; set; }
        [FieldOptional]
        public string Difficulty{ get; set; }
        [FieldOptional]
        public string Thoughts{ get; set; }
        [FieldOptional]
        public string Runtime{ get; set; }
        [FieldOptional]
        [FieldQuoted]
        public string VideoLink{ get; set; }
 
    }
}
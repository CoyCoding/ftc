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
        public string MyProperty1 { get; set; }
        [FieldOptional]
        [FieldQuoted]
        public string MyProperty2 { get; set; }
        [FieldOptional]
        public string MyProperty3 { get; set; }
        [FieldOptional]
        public string MyProperty4 { get; set; }
        [FieldOptional]
        public string MyProperty5 { get; set; }
        [FieldOptional]
        public string MyProperty6 { get; set; }
        [FieldOptional]
        [FieldQuoted]
        public string MyProperty7 { get; set; }
 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FileHelpers;

namespace FTCweb.Models
{
    [DelimitedRecord(",")]
    public class TestModel
    {
        public string Data1 { get; set; }

        public string Data2 { get; set; }

        public string Data3 { get; set; }

    }
}
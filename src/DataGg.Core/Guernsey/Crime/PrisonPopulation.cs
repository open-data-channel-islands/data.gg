﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Crime
{
    public class PrisonPopulation
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Number of prisoners")]
        public long NumberOfPrisoners { get; set; }
    }
}

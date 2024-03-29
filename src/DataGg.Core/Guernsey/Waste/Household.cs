﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Waste
{
    public class Household
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Landfill")]
        public double Landfill { get; set; }
        
        [JsonPropertyName("Recovery")]
        public double? Recovery { get; set; }

        [JsonPropertyName("Recycled")]
        public double Recycled { get; set; }

        [JsonPropertyName("Composted")]
        public double Composted { get; set; }

        [JsonPropertyName("Total")]
        public double Total { get; set; }
    }
}

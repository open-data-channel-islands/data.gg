﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Traffic
{
    public class TrafficCollisions
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Collisions")]
        public long Collisions { get; set; }
    }
}

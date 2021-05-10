using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Traffic
{
    class TrafficClassifications
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Fatal")]
        public long Fatal { get; set; }

        [JsonPropertyName("Serious")]
        public long Serious { get; set; }

        [JsonPropertyName("Slight")]
        public long Slight { get; set; }
    }
}

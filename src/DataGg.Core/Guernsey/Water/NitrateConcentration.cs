using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Water
{
    public class NitrateConcentration
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Nitrate Max")]
        public double NitrateMax { get; set; }

        [JsonPropertyName("Nitrate Mean")]
        public double NitrateMean { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.energy
{
    public class Consumption
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Domestic")]
        public double Domestic { get; set; }

        [JsonPropertyName("Commercial")]
        public double Commercial { get; set; }

        [JsonPropertyName("Total")]
        public double Total { get; set; }
    }
}

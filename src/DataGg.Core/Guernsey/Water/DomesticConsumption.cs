using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Water
{
    public class DomesticConsumption
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Consumption")]
        public double Consumption { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.energy
{
    public class Renewable
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Renewable Energy")]
        public long RenewableEnergy { get; set; }

        [JsonPropertyName("Percentage of total")]
        public double PercentageOfTotal { get; set; }
    }
}

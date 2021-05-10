using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Water
{
    public class UnaccountedWater
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Estimated Losses")]
        public long EstimatedLosses { get; set; }

        [JsonPropertyName("Annual Percentage Change")]
        public double? AnnualPercentageChange { get; set; }
    }
}

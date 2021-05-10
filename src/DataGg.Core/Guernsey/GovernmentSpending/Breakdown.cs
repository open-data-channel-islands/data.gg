using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.GovernmentSpending
{
    public class BreakdownContainer
    {
        [JsonPropertyName("Expenditure")]
        public string Expenditure { get; set; }

        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Amount")]
        public long Amount { get; set; }

        [JsonPropertyName("Percent")]
        public double Percent { get; set; }

        [JsonPropertyName("Per Capita")]
        public double PerCapita { get; set; }

        [JsonPropertyName("Breakdown")]
        public Breakdown[] Breakdown { get; set; }
    }

    public class Breakdown
    {
        [JsonPropertyName("Expenditure")]
        public string Expenditure { get; set; }

        [JsonPropertyName("Amount")]
        public long Amount { get; set; }

        [JsonPropertyName("Percent")]
        public double Percent { get; set; }

        [JsonPropertyName("Per Capita")]
        public double PerCapita { get; set; }
    }
}

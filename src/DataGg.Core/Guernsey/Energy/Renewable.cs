using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Energy
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

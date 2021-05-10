using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Energy
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

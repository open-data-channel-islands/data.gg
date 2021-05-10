using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Energy
{
    public class Gas
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Mains Gas")]
        public long MainsGas { get; set; }

        [JsonPropertyName("Bottled Gas")]
        public long BottledGas { get; set; }

        [JsonPropertyName("Total")]
        public long Total { get; set; }
    }
}

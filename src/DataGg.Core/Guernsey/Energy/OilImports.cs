using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Energy
{
    public class OilImports
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Transport")]
        public long Transport { get; set; }

        [JsonPropertyName("Heating-Electricity")]
        public long HeatingElectricity { get; set; }
    }
}

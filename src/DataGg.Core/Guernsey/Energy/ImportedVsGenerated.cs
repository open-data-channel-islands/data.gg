using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Energy
{
    public class ImportedVsGenerated
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Electricity Imported MWh")]
        public double ElectricityImportedMWh { get; set; }

        [JsonPropertyName("Electricity Generated MWh")]
        public double ElectricityGeneratedMWh { get; set; }
    }
}

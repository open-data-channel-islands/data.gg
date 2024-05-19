using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Water;

public class DomesticConsumption
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Consumption")]
    public double Consumption { get; set; }
}
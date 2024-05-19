using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Water;

public class NitrateConcentration
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Nitrate Max")]
    public double NitrateMax { get; set; }

    [JsonPropertyName("Nitrate Mean")]
    public double NitrateMean { get; set; }
}
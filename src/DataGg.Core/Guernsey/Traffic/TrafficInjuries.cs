using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Traffic;

public class TrafficInjuries
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [JsonPropertyName("Fatal")]
    public long Fatal { get; set; }

    [JsonPropertyName("Serious")]
    public long Serious { get; set; }
}
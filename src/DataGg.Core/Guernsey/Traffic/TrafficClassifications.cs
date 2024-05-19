using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Traffic;

public class TrafficClassifications
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Fatal")]
    public long Fatal { get; set; }

    [JsonPropertyName("Serious")]
    public long Serious { get; set; }

    [JsonPropertyName("Slight")]
    public long Slight { get; set; }
}
using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Houses;

public class Bedroom
{
    [JsonPropertyName("1")]
    public long The1 { get; set; }

    [JsonPropertyName("2")]
    public long The2 { get; set; }

    [JsonPropertyName("3")]
    public long The3 { get; set; }

    [JsonPropertyName("4")]
    public long The4 { get; set; }

    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Market")]
    public string Market { get; set; }

    [JsonPropertyName("Over 4")]
    public long Over4 { get; set; }

    [JsonPropertyName("Unknown")]
    public long Unknown { get; set; }
}
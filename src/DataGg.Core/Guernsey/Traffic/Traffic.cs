using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Traffic;

public class Traffic
{
    [JsonPropertyName("Offence")]
    public string Offence { get; set; }

    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Count")]
    public long? Count { get; set; }
}
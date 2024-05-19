using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Crime;

public class Crime
{
    [JsonPropertyName("Offence")]
    public string Offence { get; set; }

    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Reported")]
    public long? Reported { get; set; }

    [JsonPropertyName("Detected")]
    public long? Detected { get; set; }

    [JsonPropertyName("No Crime")]
    public long? NoCrime { get; set; }

    [JsonPropertyName("Outstanding")]
    public long? Outstanding { get; set; }
}
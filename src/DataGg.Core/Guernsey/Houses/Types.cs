using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Houses;

public class Types
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [JsonPropertyName("Local Market")]
    public long LocalMarket { get; set; }

    [JsonPropertyName("Open Market")]
    public long OpenMarket { get; set; }
}
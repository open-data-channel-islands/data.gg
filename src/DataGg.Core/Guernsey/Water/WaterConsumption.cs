using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Water;

public class WaterConsumption
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Metered")]
    public long Metered { get; set; }

    [JsonPropertyName("Unmetered")]
    public long Unmetered { get; set; }

    [JsonPropertyName("Commercial")]
    public long Commercial { get; set; }

    [JsonPropertyName("Other")]
    public long Other { get; set; }

    [JsonPropertyName("Total")]
    public long Total { get; set; }
}
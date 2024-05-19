using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Water;

public class WaterQualityCompliance
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Percentage Compliance")]
    public double PercentageCompliance { get; set; }
}
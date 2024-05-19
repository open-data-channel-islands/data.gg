using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Water;

public class WaterStorage
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Percentage Storage In Use")]
    public double PercentageStorageInUse { get; set; }
}
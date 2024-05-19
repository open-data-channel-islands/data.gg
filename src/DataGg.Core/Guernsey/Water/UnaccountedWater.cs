using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Water;

public class UnaccountedWater
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Estimated Losses")]
    public long EstimatedLosses { get; set; }

    [JsonPropertyName("Annual Percentage Change")]
    public double? AnnualPercentageChange { get; set; }
}
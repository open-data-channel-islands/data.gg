using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Earnings;

public class EarningsAgeGroup
{
    [JsonPropertyName("Age Group")]
    public string AgeGroup { get; set; }

    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Lower quartile earnings")]
    public long LowerQuartileEarnings { get; set; }

    [JsonPropertyName("Median earnings")]
    public long MedianEarnings { get; set; }

    [JsonPropertyName("Upper quartile earnings")]
    public long UpperQuartileEarnings { get; set; }
}
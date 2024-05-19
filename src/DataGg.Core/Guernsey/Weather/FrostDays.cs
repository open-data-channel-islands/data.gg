using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Weather;

public class FrostDays
{
    [JsonPropertyName("Period")]
    public string Period { get; set; }

    [JsonPropertyName("Total no. of frost days")]
    public long TotalNoOfFrostDays { get; set; }
}
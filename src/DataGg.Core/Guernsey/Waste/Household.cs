using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Waste;

public class Household
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Landfill")]
    public double Landfill { get; set; }
        
    [JsonPropertyName("Recovery")]
    public double? Recovery { get; set; }

    [JsonPropertyName("Recycled")]
    public double Recycled { get; set; }

    [JsonPropertyName("Composted")]
    public double Composted { get; set; }

    [JsonPropertyName("Total")]
    public double Total { get; set; }
}
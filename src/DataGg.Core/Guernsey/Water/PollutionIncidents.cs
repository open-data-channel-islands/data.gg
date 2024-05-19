using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Water;

public class PollutionIncidents
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Incidents")]
    public long Incidents { get; set; }
}
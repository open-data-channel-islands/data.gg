using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Traffic;

public class TrafficCollisions
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Collisions")]
    public long Collisions { get; set; }
}
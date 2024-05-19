using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Crime;

public class PrisonPopulation
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Number of prisoners")]
    public long NumberOfPrisoners { get; set; }
}
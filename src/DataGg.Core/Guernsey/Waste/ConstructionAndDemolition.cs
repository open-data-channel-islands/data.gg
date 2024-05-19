using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Waste;

public class ConstructionAndDemolition
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Land Reclamation")]
    public double LandReclamation { get; set; }

    [JsonPropertyName("Reused")]
    public double Reused { get; set; }

    [JsonPropertyName("Landfill")]
    public double Landfill { get; set; }

    [JsonPropertyName("Total")]
    public double Total { get; set; }
}
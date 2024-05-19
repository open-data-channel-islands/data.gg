using System.Linq;
using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Inflation;

public class RpiGroupChanges
{
    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [JsonPropertyName("Quarter")]
    public string Quarter { get; set; }

    [JsonPropertyName("Quarterly Change")]
    public double? QuarterlyChange { get; set; }

    [JsonPropertyName("Annual Change")]
    public double? AnnualChange { get; set; }

    public int ParsedYear => int.Parse(new string(Quarter.TakeLast(4).ToArray()));
    public string ParsedQtr => new string(Quarter.Take(2).ToArray());
}
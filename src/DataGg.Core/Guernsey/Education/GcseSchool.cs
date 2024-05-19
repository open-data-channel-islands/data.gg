using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Education;

public class GcseSchool
{
    [JsonPropertyName("Year")]
    public string Year { get; set; }

    [JsonPropertyName("School")]
    public string School { get; set; }

    [JsonPropertyName("Result")]
    public string Result { get; set; }

    [JsonPropertyName("Percent")]
    public double Percent { get; set; }
}
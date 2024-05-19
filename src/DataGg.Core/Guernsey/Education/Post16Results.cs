using System.Text.Json.Serialization;


namespace DataGg.Core.Guernsey.Education;

public class Post16Results
{
    [JsonPropertyName("Year")]
    public string Year { get; set; }

    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [JsonPropertyName("Grade")]
    public string Grade { get; set; }

    [JsonPropertyName("Percent")]
    public double Percent { get; set; }
}
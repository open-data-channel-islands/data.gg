using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Employment;

public class Totals
{
    [JsonPropertyName("Date Taken")]
    public string DateTaken { get; set; }

    [JsonPropertyName("Total in employment")]
    public long? TotalInEmployment { get; set; }

    [JsonPropertyName("Female employees")]
    public long? FemaleEmployees { get; set; }

    [JsonPropertyName("Male employees")]
    public long? MaleEmployees { get; set; }

    [JsonPropertyName("Total employees")]
    public long? TotalEmployees { get; set; }

    [JsonPropertyName("Female self-employees")]
    public long? FemaleSelfEmployees { get; set; }

    [JsonPropertyName("Male self-employees")]
    public long? MaleSelfEmployees { get; set; }

    [JsonPropertyName("Total self-employees")]
    public long? TotalSelfEmployees { get; set; }

    [JsonPropertyName("Wholly unemployed")]
    public long? WhollyUnemployed { get; set; }

    [JsonPropertyName("Total registered unemployed")]
    public long? TotalRegisteredUnemployed { get; set; }

    [JsonPropertyName("Employers")]
    public long? Employers { get; set; }
}
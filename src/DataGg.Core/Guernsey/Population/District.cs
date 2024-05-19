using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Population;

public class District
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Castel")]
    public long Castel { get; set; }

    [JsonPropertyName("South East")]
    public long SouthEast { get; set; }

    [JsonPropertyName("St. Peter Port North")]
    public long StPeterPortNorth { get; set; }

    [JsonPropertyName("St. Peter Port South")]
    public long StPeterPortSouth { get; set; }

    [JsonPropertyName("St. Sampson")]
    public long StSampson { get; set; }

    [JsonPropertyName("Vale")]
    public long Vale { get; set; }

    [JsonPropertyName("West")]
    public long West { get; set; }

    [JsonPropertyName("Address unknown")]
    public long AddressUnknown { get; set; }
}
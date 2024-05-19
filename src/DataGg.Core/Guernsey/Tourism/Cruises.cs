using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Tourism;

public class Cruises
{
    [JsonPropertyName("Date")]
    public string Date { get; set; }

    [JsonPropertyName("No. of cruise passengers")]
    public long NoOfCruisePassengers { get; set; }
}
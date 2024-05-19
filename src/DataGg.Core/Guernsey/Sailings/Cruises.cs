using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Sailings;

public class Cruises
{
    [JsonPropertyName("Arrival Date")]
    public string ArrivalDate { get; set; }

    [JsonPropertyName("Ship")]
    public string Ship { get; set; }

    [JsonPropertyName("Port of Registry")]
    public string PortOfRegistry { get; set; }

    [JsonPropertyName("Pax")]
    public double? Pax { get; set; }

    [JsonPropertyName("Arrival From")]
    public string ArrivalFrom { get; set; }

    [JsonPropertyName("Departure To")]
    public string DepartureTo { get; set; }

    [JsonPropertyName("Departure Date")]
    public string DepartureDate { get; set; }

    [JsonPropertyName("Agent")]
    public string Agent { get; set; }
}
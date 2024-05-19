using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Transport;

public class RegisteredVehicles
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Motor Vehicles Private")]
    public long MotorVehiclesPrivate { get; set; }

    [JsonPropertyName("Motor Vehicles Commercial")]
    public long MotorVehiclesCommercial { get; set; }

    [JsonPropertyName("Motor Cycles")]
    public long MotorCycles { get; set; }
}
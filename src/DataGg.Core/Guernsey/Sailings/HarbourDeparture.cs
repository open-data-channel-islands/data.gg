using System;
using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Sailings;

public class Harbour
{
    public string Vessel { get; set; }
    public DateTimeOffset Time { get; set; }
    public string Type { get; set; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Destination { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Departed { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Source { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public string Arrived { get; set; }
}
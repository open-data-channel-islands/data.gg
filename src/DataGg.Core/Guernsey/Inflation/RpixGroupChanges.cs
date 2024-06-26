﻿using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Inflation;

public class RpixGroupChanges
{
    [JsonPropertyName("Type")]
    public string Type { get; set; }

    [JsonPropertyName("Quarter")]
    public string Quarter { get; set; }

    [JsonPropertyName("Quarterly Change")]
    public double? QuarterlyChange { get; set; }

    [JsonPropertyName("Annual Change")]
    public double? AnnualChange { get; set; }
}
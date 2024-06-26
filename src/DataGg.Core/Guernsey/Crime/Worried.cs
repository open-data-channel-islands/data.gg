﻿using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Crime;

public class Worried
{
    [JsonPropertyName("Year")]
    public long Year { get; set; }

    [JsonPropertyName("Very worried")]
    public double VeryWorried { get; set; }

    [JsonPropertyName("Fairly worried")]
    public double FairlyWorried { get; set; }

    [JsonPropertyName("Not very worried")]
    public double NotVeryWorried { get; set; }

    [JsonPropertyName("Not at all worried")]
    public double NotAtAllWorried { get; set; }
}
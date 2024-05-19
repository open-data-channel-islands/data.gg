using System;

namespace DataGg.Core.Guernsey.Flights;

public abstract class FlightBase
{
    public string FlightNumber { get; set; }
    public DateTimeOffset Time { get; set; }
    public string Status { get; set; }
}
public class Departure : FlightBase 
{
    public string Dest { get; set; }
}
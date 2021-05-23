using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Flights
{
    public abstract class FlightBase
    {
        public string FlightNumber { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; }
    }
    public class Departure : FlightBase 
    {
        public string Dest { get; set; }
    }
}

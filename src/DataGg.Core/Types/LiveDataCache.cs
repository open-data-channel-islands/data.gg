using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGg.Core.Types
{
    public class LiveDataCache
    {
        public IEnumerable<Guernsey.Flights.Arrival> AirportArrivals { get; set; }
        public IEnumerable<Guernsey.Flights.Departure> AirportDepartures{ get; set; }
        public IEnumerable<Guernsey.Sailings.Harbour> Harbour { get; set; }

        public const string FlightsArrivals = "get_flights_arrivals";
        public const string FlightsDepartures = "get_flights_departures";
        public const string SailingsHarbour = "get_harbour_sailings";
    }
}

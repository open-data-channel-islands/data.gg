using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Sailings
{
    public abstract class HarbourBase
    {
        public string Vessel { get; set; }
        public DateTime Time { get; set; }
        public string Type { get; set; }
    }
    public class HarbourDeparture : HarbourBase
    {
        public string Destination { get; set; }
        public DateTime? Departed { get; set; }
    }

    public class HarbourArrival : HarbourBase
    {
        public string Source { get; set; }
        public DateTime? Arrived { get; set; }
    }
}

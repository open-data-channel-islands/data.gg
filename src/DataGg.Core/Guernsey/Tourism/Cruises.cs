using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Tourism
{
    class Cruises
    {
        [JsonPropertyName("Date")]
        public string Date { get; set; }

        [JsonPropertyName("No. of cruise passengers")]
        public long NoOfCruisePassengers { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Weather
{
    class FrostDays
    {
        [JsonPropertyName("Period")]
        public string Period { get; set; }

        [JsonPropertyName("Total no. of frost days")]
        public long TotalNoOfFrostDays { get; set; }
    }
}

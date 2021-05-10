using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Education
{
    public class GcseOverall
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Result")]
        public string Result { get; set; }

        [JsonPropertyName("Percent")]
        public double Percent { get; set; }
    }
}

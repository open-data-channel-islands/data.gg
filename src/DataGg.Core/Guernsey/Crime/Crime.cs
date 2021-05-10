using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.crime
{
    public class Crime
    {
        [JsonPropertyName("Offence")]
        public string Offence { get; set; }

        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Reported")]
        public long? Reported { get; set; }

        [JsonPropertyName("Detected")]
        public long? Detected { get; set; }

        [JsonPropertyName("No Crime")]
        public long? NoCrime { get; set; }

        [JsonPropertyName("Outstanding")]
        public long? Outstanding { get; set; }
        }
    
}

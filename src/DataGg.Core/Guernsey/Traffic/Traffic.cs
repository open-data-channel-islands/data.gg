using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Traffic
{
    public class Traffic
    {
        [JsonPropertyName("Offence")]
        public string Offence { get; set; }

        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Count")]
        public long? Count { get; set; }
    }
}

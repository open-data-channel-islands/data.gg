using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Tourism
{
    public class SeaByMonth
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("January")]
        public long? January { get; set; }

        [JsonPropertyName("February")]
        public long? February { get; set; }

        [JsonPropertyName("March")]
        public long? March { get; set; }

        [JsonPropertyName("April")]
        public long? April { get; set; }

        [JsonPropertyName("May")]
        public long? May { get; set; }

        [JsonPropertyName("June")]
        public long? June { get; set; }

        [JsonPropertyName("July")]
        public long? July { get; set; }

        [JsonPropertyName("August")]
        public long? August { get; set; }

        [JsonPropertyName("September")]
        public long? September { get; set; }

        [JsonPropertyName("October")]
        public long? October { get; set; }

        [JsonPropertyName("November")]
        public long? November { get; set; }

        [JsonPropertyName("December")]
        public long? December { get; set; }
    }
}

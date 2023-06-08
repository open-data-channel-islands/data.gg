using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Earnings
{
    public class EarningsSex
    {
        [JsonPropertyName("Date")]
        public string Date { get; set; }

        [JsonPropertyName("Female")]
        public long Female { get; set; }

        [JsonPropertyName("Male")]
        public long Male { get; set; }

        [JsonPropertyName("Total")]
        public long Total { get; set; }
    }
}

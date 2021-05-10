using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Earnings
{
    public class EarningsSector
    {
        [JsonPropertyName("Sector")]
        public string Sector { get; set; }

        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Lower quartile earnings")]
        public long LowerQuartileEarnings { get; set; }

        [JsonPropertyName("Median earnings")]
        public long MedianEarnings { get; set; }

        [JsonPropertyName("Upper quartile earnings")]
        public long UpperQuartileEarnings { get; set; }
    }
}

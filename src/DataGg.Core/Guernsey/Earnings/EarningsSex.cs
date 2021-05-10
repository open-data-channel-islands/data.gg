using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Earnings
{
    class EarningsSex
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Sex")]
        public string Sex { get; set; }

        [JsonPropertyName("Nominal median earnings")]
        public long NominalMedianEarnings { get; set; }

        [JsonPropertyName("Real median earnings")]
        public long RealMedianEarnings { get; set; }
    }
}

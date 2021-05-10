using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Houses
{
    public class OpenPrices
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Valid")]
        public bool Valid { get; set; }

        [JsonPropertyName("Quarter")]
        public string Quarter { get; set; }

        [JsonPropertyName("Median")]
        public long Median { get; set; }

        [JsonPropertyName("Transactions")]
        public long? Transactions { get; set; }
    }
}

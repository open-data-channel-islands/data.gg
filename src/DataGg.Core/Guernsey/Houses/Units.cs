using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Houses
{
    public class Units
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Local Market")]
        public long LocalMarket { get; set; }

        [JsonPropertyName("Open Market")]
        public long OpenMarket { get; set; }
    }
}

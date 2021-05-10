using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Houses
{
    class Types
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("Local Market")]
        public long LocalMarket { get; set; }

        [JsonPropertyName("Open Market")]
        public long OpenMarket { get; set; }
    }

}

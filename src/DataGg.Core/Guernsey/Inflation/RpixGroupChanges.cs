using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Inflation
{
    class RpixGroupChanges
    {
        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("Quarter")]
        public string Quarter { get; set; }

        [JsonPropertyName("Quarterly Change")]
        public double? QuarterlyChange { get; set; }

        [JsonPropertyName("Annual Change")]
        public double? AnnualChange { get; set; }
    }
}

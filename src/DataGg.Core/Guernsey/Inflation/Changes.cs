using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Inflation
{
    public class Changes
    {
        [JsonPropertyName("Quarter")]
        public string Quarter { get; set; }

        [JsonPropertyName("RPIX Annual Change")]
        public double? RpixAnnualChange { get; set; }

        [JsonPropertyName("RPIX Quarterly Change")]
        public double? RpixQuarterlyChange { get; set; }

        [JsonPropertyName("RPI Annual Change")]
        public double? RpiAnnualChange { get; set; }

        [JsonPropertyName("RPI Quarterly Change")]
        public double? RpiQuarterlyChange { get; set; }
    }
}

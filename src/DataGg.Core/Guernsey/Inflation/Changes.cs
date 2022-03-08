using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DataGg.Core.Attributes;

namespace DataGg.Core.Guernsey.Inflation
{
    public class Changes
    {
        // argh, why doesn't this get converted to a date without mucking about
        [JsonPropertyName("Quarter")]
        public string Quarter { get; set; }

        [ChartSeriesColumn(UsedForGrouping = true, Format = "yyyy MMM")]
        public DateTime Date => DateTime.ParseExact(Quarter, "dd/MM/yyyy",  CultureInfo.InvariantCulture);
        
        [JsonPropertyName("RPIX Annual Change")]
        public double? RpixAnnualChange { get; set; }

        [JsonPropertyName("RPIX Quarterly Change")]
        public double? RpixQuarterlyChange { get; set; }

        [JsonPropertyName("RPI Annual Change")]
        public double? RpiAnnualChange { get; set; }

        [JsonPropertyName("RPI Quarterly Change")]
        [ChartSeriesColumn(DisplayName = "RPI QTR Change", CalcMethod = CalcMethod.PercentChange)]
        public double? RpiQuarterlyChange { get; set; }
    }
}

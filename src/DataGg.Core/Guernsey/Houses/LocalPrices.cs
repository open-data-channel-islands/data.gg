using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using DataGg.Core.Attributes;

namespace DataGg.Core.Guernsey.Houses
{
    public class LocalPrices
    {
        [ChartSeriesColumn(UsedForGrouping = true)]
        public string OrderColumn => $"{Year} {Quarter}";
            
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Valid")]
        public bool Valid { get; set; }

        [JsonPropertyName("Quarter")]
        public string Quarter { get; set; }

        [JsonPropertyName("Mean")]
        [ChartSeriesColumn(GroupName = "Mean")]
        public double Mean { get; set; }

        [JsonPropertyName("Median")]
        public long? Median { get; set; }

        [JsonPropertyName("Houses median")]
        public double? HousesMedian { get; set; }

        [JsonPropertyName("Apartments median")]
        public long? ApartmentsMedian { get; set; }

        [JsonPropertyName("Mix adjusted")]
        public double? MixAdjusted { get; set; }

        [JsonPropertyName("Transactions")]
        [ChartSeriesColumn(GroupName = "Transactions")]
        public long? Transactions { get; set; }
    }
}

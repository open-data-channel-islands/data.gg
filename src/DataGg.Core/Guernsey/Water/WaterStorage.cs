using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Water
{
    public class WaterStorage
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Percentage Storage In Use")]
        public double PercentageStorageInUse { get; set; }
    }
}

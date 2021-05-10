using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Health
{
    class ChestAndHeartTotals
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("All screenings")]
        public long AllScreenings { get; set; }

        [JsonPropertyName("New clients")]
        public long NewClients { get; set; }

        [JsonPropertyName("Age 25-34")]
        public long Age2534 { get; set; }

        [JsonPropertyName("Age 35-44")]
        public long Age3544 { get; set; }

        [JsonPropertyName("Age 45-54")]
        public long Age4554 { get; set; }

        [JsonPropertyName("Age 55-64")]
        public long Age5564 { get; set; }

        [JsonPropertyName("Age 65-69")]
        public long Age6569 { get; set; }

        [JsonPropertyName("Age 70-75")]
        public long Age7075 { get; set; }
    }
}

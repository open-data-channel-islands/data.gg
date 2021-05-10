using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Finance
{
    class FundsUnderManagement
    {
        [JsonPropertyName("Quarter")]
        public string Quarter { get; set; }

        [JsonPropertyName("ClosedEndedFunds")]
        public long ClosedEndedFunds { get; set; }

        [JsonPropertyName("OpenEndedFunds")]
        public long OpenEndedFunds { get; set; }

        [JsonPropertyName("TotalFunds")]
        public long TotalFunds { get; set; }

        [JsonPropertyName("ClosedEndedFundNAV")]
        public long ClosedEndedFundNav { get; set; }

        [JsonPropertyName("OpenEndedFundNAV")]
        public long OpenEndedFundNav { get; set; }

        [JsonPropertyName("TotalNAV")]
        public long TotalNav { get; set; }

        [JsonPropertyName("ClosedEndedFundNAVAvg")]
        public long ClosedEndedFundNavAvg { get; set; }

        [JsonPropertyName("OpenEndedFundNAVAvg")]
        public long OpenEndedFundNavAvg { get; set; }

        [JsonPropertyName("TotalNAVAvg")]
        public long TotalNavAvg { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Finance
{
    class Banking
    {
        [JsonPropertyName("Quarter")]
        public string Quarter { get; set; }

        [JsonPropertyName("BankingLicences")]
        public long BankingLicences { get; set; }

        [JsonPropertyName("TotalDeposits")]
        public long TotalDeposits { get; set; }

        [JsonPropertyName("PercentageChange")]
        public double PercentageChange { get; set; }
    }
}

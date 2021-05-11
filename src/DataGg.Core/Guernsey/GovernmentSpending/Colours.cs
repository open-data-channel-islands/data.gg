using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.GovernmentSpending
{
    public class Colours
    {
        [JsonPropertyName("Healthandcommunityservices")]
        public string Healthandcommunityservices { get; set; }

        [JsonPropertyName("Oldagepensions")]
        public string Oldagepensions { get; set; }

        [JsonPropertyName("Education")]
        public string Education { get; set; }

        [JsonPropertyName("Socialwelfarebenefits")]
        public string Socialwelfarebenefits { get; set; }

        [JsonPropertyName("Orderandsafety")]
        public string Orderandsafety { get; set; }

        [JsonPropertyName("Governmentandadministration")]
        public string Governmentandadministration { get; set; }

        [JsonPropertyName("Capitalinvestment")]
        public string Capitalinvestment { get; set; }

        [JsonPropertyName("Landmanagementinfrastructureandtransport")]
        public string Landmanagementinfrastructureandtransport { get; set; }

        [JsonPropertyName("Economicdevelopmentandtourism")]
        public string Economicdevelopmentandtourism { get; set; }

        [JsonPropertyName("Artssportandculture")]
        public string Artssportandculture { get; set; }

        [JsonPropertyName("Alderney")]
        public string Alderney { get; set; }

        [JsonPropertyName("Overseasaid")]
        public string Overseasaid { get; set; }
    }
}

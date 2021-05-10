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
        [JsonPropertyName("Health and community services")]
        public string HealthAndCommunityServices { get; set; }

        [JsonPropertyName("Old age pensions")]
        public string OldAgePensions { get; set; }

        [JsonPropertyName("Education")]
        public string Education { get; set; }

        [JsonPropertyName("Social welfare benefits")]
        public string SocialWelfareBenefits { get; set; }

        [JsonPropertyName("Order and safety")]
        public string OrderAndSafety { get; set; }

        [JsonPropertyName("Government and administration")]
        public string GovernmentAndAdministration { get; set; }

        [JsonPropertyName("Capital investment")]
        public string CapitalInvestment { get; set; }

        [JsonPropertyName("Land management infrastructure and transport")]
        public string LandManagementInfrastructureAndTransport { get; set; }

        [JsonPropertyName("Economic development and tourism")]
        public string EconomicDevelopmentAndTourism { get; set; }

        [JsonPropertyName("Arts sport and culture")]
        public string ArtsSportAndCulture { get; set; }

        [JsonPropertyName("Alderney")]
        public string Alderney { get; set; }

        [JsonPropertyName("Overseas aid")]
        public string OverseasAid { get; set; }
    }
}

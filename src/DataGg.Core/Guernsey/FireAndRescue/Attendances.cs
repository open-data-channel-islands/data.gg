using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.FireAndRescue
{
    class Attendances
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("All other types of fires")]
        public long AllOtherTypesOfFires { get; set; }

        [JsonPropertyName("Chimney fires")]
        public long ChimneyFires { get; set; }

        [JsonPropertyName("False alarms general")]
        public long FalseAlarmsGeneral { get; set; }

        [JsonPropertyName("False alarms malicious")]
        public long FalseAlarmsMalicious { get; set; }

        [JsonPropertyName("Special service emergency")]
        public long? SpecialServiceEmergency { get; set; }

        [JsonPropertyName("Special service non-emergency")]
        public long? SpecialServiceNonEmergency { get; set; }

        [JsonPropertyName("Special service Road Traffic Collisions")]
        public long? SpecialServiceRoadTrafficCollisions { get; set; }

        [JsonPropertyName("Special service General")]
        public long? SpecialServiceGeneral { get; set; }
    }
}

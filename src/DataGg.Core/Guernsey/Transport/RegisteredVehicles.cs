using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Transport
{
    class RegisteredVehicles
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("Motor Vehicles Private")]
        public long MotorVehiclesPrivate { get; set; }

        [JsonPropertyName("Motor Vehicles Commercial")]
        public long MotorVehiclesCommercial { get; set; }

        [JsonPropertyName("Motor Cycles")]
        public long MotorCycles { get; set; }
    }
}

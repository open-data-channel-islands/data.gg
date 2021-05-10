using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Health
{
    public class ChestAndHeartConcerns
    {
        [JsonPropertyName("Year")]
        public long Year { get; set; }

        [JsonPropertyName("All screenings")]
        public long AllScreenings { get; set; }

        [JsonPropertyName("New clients included in screenings total")]
        public long NewClientsIncludedInScreeningsTotal { get; set; }

        [JsonPropertyName("Body Mass Index greater or equal to 30")]
        public long BodyMassIndexGreaterOrEqualTo30 { get; set; }

        [JsonPropertyName("Diabetes found in screening")]
        public long? DiabetesFoundInScreening { get; set; }

        [JsonPropertyName("Raised Blood Pressure")]
        public long RaisedBloodPressure { get; set; }

        [JsonPropertyName("Raised Cholesterol")]
        public long RaisedCholesterol { get; set; }

        [JsonPropertyName("Abnormal ECG")]
        public long? AbnormalEcg { get; set; }

        [JsonPropertyName("Visceral Fat greater than 13")]
        public long? VisceralFatGreaterThan13 { get; set; }
    }
}

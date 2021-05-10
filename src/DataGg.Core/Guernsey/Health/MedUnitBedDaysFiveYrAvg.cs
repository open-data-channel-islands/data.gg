using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataGg.Core.Guernsey.Health
{
    public class MedUnitBedDaysFiveYrAvg
    {
        [JsonPropertyName("Sex")]
        public string Sex { get; set; }

        [JsonPropertyName("Mean Period")]
        public string MeanPeriod { get; set; }

        [JsonPropertyName("Certain infectious and parasitic diseases")]
        public double CertainInfectiousAndParasiticDiseases { get; set; }

        [JsonPropertyName("Congenital malformations deformations and chromosomal abnormalities")]
        public double CongenitalMalformationsDeformationsAndChromosomalAbnormalities { get; set; }

        [JsonPropertyName("Diseases of the blood and blood-forming organs")]
        public double DiseasesOfTheBloodAndBloodFormingOrgans { get; set; }

        [JsonPropertyName("Diseases of the circulatory system")]
        public double DiseasesOfTheCirculatorySystem { get; set; }

        [JsonPropertyName("Diseases of the digestive system")]
        public double DiseasesOfTheDigestiveSystem { get; set; }

        [JsonPropertyName("Diseases of the ear and mastoid process")]
        public double DiseasesOfTheEarAndMastoidProcess { get; set; }

        [JsonPropertyName("Diseases of the eye and adnexa")]
        public double DiseasesOfTheEyeAndAdnexa { get; set; }

        [JsonPropertyName("Diseases of the genitourinary system")]
        public double DiseasesOfTheGenitourinarySystem { get; set; }

        [JsonPropertyName("Diseases of the musculoskeletal system")]
        public double DiseasesOfTheMusculoskeletalSystem { get; set; }

        [JsonPropertyName("Diseases of the nervous system")]
        public double DiseasesOfTheNervousSystem { get; set; }

        [JsonPropertyName("Diseases of the respiratory system")]
        public double DiseasesOfTheRespiratorySystem { get; set; }

        [JsonPropertyName("Diseases of the skin")]
        public double DiseasesOfTheSkin { get; set; }

        [JsonPropertyName("Endocrine nutritional and metabolic diseases")]
        public double EndocrineNutritionalAndMetabolicDiseases { get; set; }

        [JsonPropertyName("Factors influencing health status and contact with health services")]
        public double FactorsInfluencingHealthStatusAndContactWithHealthServices { get; set; }

        [JsonPropertyName("Injury poisoning and consequences of external causes")]
        public double InjuryPoisoningAndConsequencesOfExternalCauses { get; set; }

        [JsonPropertyName("Mental and behavioural disorders")]
        public double MentalAndBehaviouralDisorders { get; set; }

        [JsonPropertyName("Neoplasms")]
        public double Neoplasms { get; set; }

        [JsonPropertyName("Other")]
        public double Other { get; set; }

        [JsonPropertyName("Pregnancy birth and the puerperium")]
        public double PregnancyBirthAndThePuerperium { get; set; }

        [JsonPropertyName("Symptoms signs and abnormal clinical and lab findings NEC")]
        public double SymptomsSignsAndAbnormalClinicalAndLabFindingsNec { get; set; }
    }
}

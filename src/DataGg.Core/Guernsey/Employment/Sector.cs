using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Employment;

public class Sector
{
    [JsonPropertyName("Date Taken")]
    public string DateTaken { get; set; }

    [JsonPropertyName("Agriculture, Horticulture, Fishing and Quarrying")]
    public long AgricultureHorticultureFishingAndQuarrying { get; set; }

    [JsonPropertyName("Manufacturing")]
    public long Manufacturing { get; set; }

    [JsonPropertyName("Electricity, gas, steam and air conditioning supply")]
    public long ElectricityGasSteamAndAirConditioningSupply { get; set; }

    [JsonPropertyName("Water supply, sewerage, waste management and remediation activities")]
    public long WaterSupplySewerageWasteManagementAndRemediationActivities { get; set; }

    [JsonPropertyName("Construction")]
    public long Construction { get; set; }

    [JsonPropertyName("Wholesale, retail and repairs")]
    public long WholesaleRetailAndRepairs { get; set; }

    [JsonPropertyName("Hostelry")]
    public long Hostelry { get; set; }

    [JsonPropertyName("Transport and storage")]
    public long TransportAndStorage { get; set; }

    [JsonPropertyName("Information and communication")]
    public long InformationAndCommunication { get; set; }

    [JsonPropertyName("Finance")]
    public long Finance { get; set; }

    [JsonPropertyName("Real estate activities")]
    public long RealEstateActivities { get; set; }

    [JsonPropertyName("Professional, business, scientific and technical activities")]
    public long ProfessionalBusinessScientificAndTechnicalActivities { get; set; }

    [JsonPropertyName("Administrative and support service activities")]
    public long AdministrativeAndSupportServiceActivities { get; set; }

    [JsonPropertyName("Public administration")]
    public long PublicAdministration { get; set; }

    [JsonPropertyName("Education")]
    public long Education { get; set; }

    [JsonPropertyName("Human health, social and charitable work activities")]
    public long HumanHealthSocialAndCharitableWorkActivities { get; set; }

    [JsonPropertyName("Arts, entertainment and recreation")]
    public long ArtsEntertainmentAndRecreation { get; set; }

    [JsonPropertyName("Other service activities")]
    public long OtherServiceActivities { get; set; }

    [JsonPropertyName("Activities of households as employers; undifferentiated goods and services producing activities of households for own use")]
    public long ActivitiesOfHouseholdsAsEmployersUndifferentiatedGoodsAndServicesProducingActivitiesOfHouseholdsForOwnUse { get; set; }

    [JsonPropertyName("Other")]
    public long Other { get; set; }

    [JsonPropertyName("Total")]
    public long Total { get; set; }
}
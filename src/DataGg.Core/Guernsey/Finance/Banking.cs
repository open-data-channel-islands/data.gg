using System.Text.Json.Serialization;

namespace DataGg.Core.Guernsey.Finance;

public class Banking
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
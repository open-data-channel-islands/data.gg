using System.Collections.Generic;
using System.Linq;
using DataGg.Core.Attributes;
using DataGg.Core.Guernsey.Buses;
using DataGg.Core.Guernsey.Crime;
using DataGg.Core.Guernsey.Earnings;
using DataGg.Core.Guernsey.Education;
using DataGg.Core.Guernsey.Emissions;
using DataGg.Core.Guernsey.Employment;
using DataGg.Core.Guernsey.Energy;
using DataGg.Core.Guernsey.Finance;
using DataGg.Core.Guernsey.FireAndRescue;
using DataGg.Core.Guernsey.GovernmentSpending;
using DataGg.Core.Guernsey.Health;
using DataGg.Core.Guernsey.Houses;
using DataGg.Core.Guernsey.Inflation;
using DataGg.Core.Guernsey.OverseasAid;
using DataGg.Core.Guernsey.Population;
using DataGg.Core.Guernsey.Sailings;
using DataGg.Core.Guernsey.Tourism;
using DataGg.Core.Guernsey.Traffic;
using DataGg.Core.Guernsey.Transport;
using DataGg.Core.Guernsey.Waste;
using DataGg.Core.Guernsey.Water;
using DataGg.Core.Guernsey.Weather;

namespace DataGg.Core.Types;

public class DataCache
{
    public IEnumerable<BusUsage> BusUsage { get; init; }
    public IEnumerable<Crime> Crime { get; init; }
    public IEnumerable<PrisonPopulation> CrimePrisonPopulation { get; init; }
    public IEnumerable<Worried> CrimeWorried { get; init; }
    public IEnumerable<EarningsAgeGroup> EarningsAgeGroup { get; init; }
    public IEnumerable<EarningsSector> EarningsSector { get; init; }
    public IEnumerable<EarningsSex> EarningsSex { get; init; }
    public IEnumerable<GcseOverall> EducationGcseOverall { get; init; }
    public IEnumerable<GcseSchool> EducationGcseSchool { get; init; }
    public IEnumerable<Post16Results> EducationPost16Results { get; init; }
    public IEnumerable<StudentsInUk> EducationStudentsInUk { get; init; }
    public IEnumerable<Source> EmissionSource { get; init; }
    public IEnumerable<Type> EmissionType { get; init; }
    public IEnumerable<Sector> EmploymentSector { get; init; }
    public IEnumerable<Totals> EmploymentTotals { get; init; }
    public IEnumerable<Consumption> EnergyElectricityConsumption { get; init; }
    public IEnumerable<ImportedVsGenerated> EnergyElectricityImportVsGenerated { get; init; }
    public IEnumerable<Gas> EnergyGas { get; init; }
    public IEnumerable<OilImports> EnergyOilImports { get; init; }
    public IEnumerable<Renewable> EnergyRenewable { get; init; }
    public IEnumerable<Banking> FinanceBanking { get; init; }
    public IEnumerable<FundsUnderManagement> FinanceFundsUnderManagement { get; init; }
    public IEnumerable<Attendances> FireAndRescueAttendances { get; init; }
    public IEnumerable<Breakdown> GovSpendingBreakdown { get; init; }
    public IEnumerable<ChestAndHeartConcerns> HealthChestAndHeartConcerns { get; init; }
    public IEnumerable<ChestAndHeartTotals> HealthChestAndHeartTotals { get; init; }
    public IEnumerable<MedUnitBedDaysFiveYrAvg> HealthMedUnitBedDaysFiveYrAvg { get; init; }
    public IEnumerable<MedicalUnitBedDays> HealthMedicalUnitBedDays { get; init; }
    public IEnumerable<Bedroom> HouseBedrooms { get; init; }
    public IEnumerable<LocalPrices> HouseLocalPrices { get; init; }
    public IEnumerable<OpenPrices> HouseOpenPrices { get; init; }
    public IEnumerable<Guernsey.Houses.Types> HouseTypes { get; init; }
    public IEnumerable<Units> HouseUnits { get; init; }
    public IEnumerable<Guernsey.Inflation.Changes> InflationChanges { get; init; }
    public IEnumerable<RpixGroupChanges> InflationRpixGroupChanges { get; init; }
    public IEnumerable<RpiGroupChanges> InflationRpiGroupChanges { get; init; }
    public IEnumerable<Contributions> OverseasContributions { get; init; }
    public IEnumerable<Age> PopulationAge { get; init; }
    public IEnumerable<AgeFemale> PopulationAgeFemale { get; init; }
    public IEnumerable<AgeMale> PopulationAgeMale { get; init; }
    public IEnumerable<Birthplace> PopulationBirthplace { get; init; }
    public IEnumerable<Guernsey.Population.Changes> PopulationChanges { get; init; }
    public IEnumerable<District> PopulationDistrict { get; init; }
    public IEnumerable<Parish> PopulationParish { get; init; }
    public IEnumerable<Population> Population { get; init; }
    public IEnumerable<CondorPunctuality> SailingsCondorPunctuality { get; init; }
    public IEnumerable<Guernsey.Sailings.Cruises> SailingsCruises { get; init; }
    public IEnumerable<AirByMonth> TourismAirByMonth { get; init; }
    public IEnumerable<Guernsey.Tourism.Cruises> TourismCruises { get; init; }
    public IEnumerable<SeaByMonth> TourismSeaByMonth { get; init; }
    public IEnumerable<Traffic> Traffic { get; init; }
    public IEnumerable<TrafficClassifications> TrafficClassifications { get; init; }
    public IEnumerable<TrafficCollisions> TrafficCollisions { get; init; }
    public IEnumerable<TrafficInjuries> TrafficInjuries { get; init; }
    public IEnumerable<RegisteredVehicles> TransportRegisteredVehicles { get; init; }
    public IEnumerable<CommericalAndIndustrial> WasteCommercialAndIndustrial { get; init; }
    public IEnumerable<ConstructionAndDemolition> WasteConstructionAndDemolition { get; init; }
    public IEnumerable<Household> WasteHousehold { get; init; }
    public IEnumerable<DomesticConsumption> WaterDomesticConsumption { get; init; }
    public IEnumerable<NitrateConcentration> WaterNitrateConcentration { get; init; }
    public IEnumerable<PollutionIncidents> WaterPollutionIncidents { get; init; }
    public IEnumerable<UnaccountedWater> WaterUnaccounted { get; init; }
    public IEnumerable<WaterConsumption> WaterConsumption { get; init; }
    public IEnumerable<WaterQualityCompliance> WaterQualityCompliance { get; init; }
    public IEnumerable<WaterStorage> WaterStorage { get; init; }
    public IEnumerable<FrostDays> WeatherFrostDays { get; init; }
    public IEnumerable<MetOfficeAnnual> WeatherMetOfficeAnnual { get; init; }
    public IEnumerable<MetOfficeMonthly> WeatherMetOfficeMonthly { get; init; }

    public ChartingData GetChartingDataForType(System.Type type)
    {
        var items = GetFromType(type);

        var columns = ChartSeriesColumn.GetColumnsForGeneric(type);

        // only 1 supported at mo
        var chartSeriesColumns = columns as ChartSeriesColumn[] ?? columns.ToArray();
            
        var groupCol = chartSeriesColumns.FirstOrDefault(x => x.UsedForGrouping);

        if (groupCol != null)
        {
            items = items.OrderBy(x => groupCol.PropertyInfo.GetValue(x));
        }
            
        return new ChartingData
        {
            OrderedItems = items,
            Columns = chartSeriesColumns.Where(c=> !c.UsedForGrouping).ToArray(),
            GroupingColumn = groupCol
        };
    }

    private IEnumerable<object> GetFromType(System.Type type)
    {
        var propertyInfos = GetType().GetProperties().ToArray();
        foreach (var p in propertyInfos)
        {
            if (p.PropertyType.IsGenericType &&
                p.PropertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>))
            {
                var elementType = p.PropertyType.GetGenericArguments().FirstOrDefault();

                if (elementType == type)
                {
                    return (IEnumerable<object>)p.GetValue(this);
                }
            }
        }

        return null;
    }
}
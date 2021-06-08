using System.Collections.Generic;
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

namespace DataGg.Core.Types
{

    public class DataCache
    {
        public IEnumerable<BusUsage> BusUsage { get; set; }
        public IEnumerable<Crime> Crime { get; set; }
        public IEnumerable<PrisonPopulation> CrimePrisonPopulation { get; set; }
        public IEnumerable<Worried> CrimeWorried { get; set; }
        public IEnumerable<EarningsAgeGroup> EarningsAgeGroup { get; set; }
        public IEnumerable<EarningsSector> EducationEarningsSector { get; set; }
        public IEnumerable<EarningsSex> EducationEarningsSex { get; set; }
        public IEnumerable<GcseOverall> EducationGcseOverall { get; set; }
        public IEnumerable<GcseSchool> EducationGcseSchool { get; set; }
        public IEnumerable<Post16Results> EducationPost16Results { get; set; }
        public IEnumerable<StudentsInUk> EducationStudentsInUk { get; set; }
        public IEnumerable<Source> EmissionSource { get; set; }
        public IEnumerable<Type> EmissionType { get; set; }
        public IEnumerable<Sector> EmploymentSector { get; set; }
        public IEnumerable<Totals> EmploymentTotals { get; set; }
        public IEnumerable<Consumption> EnergyElectricityConsumption { get; set; }
        public IEnumerable<ImportedVsGenerated> EnergyElectricityImportVsGenerated { get; set; }
        public IEnumerable<Gas> EnergyGas { get; set; }
        public IEnumerable<OilImports> EnergyOilImports { get; set; }
        public IEnumerable<Renewable> EnergyRenewable { get; set; }
        public IEnumerable<Banking> FinanceBanking { get; set; }
        public IEnumerable<FundsUnderManagement> FinanceFundsUnderManagement { get; set; }
        public IEnumerable<Attendances> FireAndRescueAttendances { get; set; }
        public IEnumerable<Breakdown> GovSpendingBreakdown { get; set; }
        public IEnumerable<ChestAndHeartConcerns> HealthChestAndHeartConcerns { get; set; }
        public IEnumerable<ChestAndHeartTotals> HealthChestAndHeartTotals { get; set; }
        public IEnumerable<MedUnitBedDaysFiveYrAvg> HealthMedUnitBedDaysFiveYrAvg { get; set; }
        public IEnumerable<Bedroom> HouseBedrooms { get; set; }
        public IEnumerable<LocalPrices> HouseLocalPrices { get; set; }
        public IEnumerable<OpenPrices> HouseOpenPrices { get; set; }
        public IEnumerable<Guernsey.Houses.Types> HouseTypes { get; set; }
        public IEnumerable<Units> HouseUnits { get; set; }
        public IEnumerable<Guernsey.Inflation.Changes> InflationChanges { get; set; }
        public IEnumerable<RpixGroupChanges> InflationRpixGroupChanges { get; set; }
        public IEnumerable<RpiGroupChanges> InflationRpiGroupChanges { get; set; }
        public IEnumerable<Contributions> OverseasContributions { get; set; }
        public IEnumerable<Age> PopulationAge { get; set; }
        public IEnumerable<AgeFemale> PopulationAgeFemale { get; set; }
        public IEnumerable<AgeMale> PopulationAgeMale { get; set; }
        public IEnumerable<Birthplace> PopulationBirthplace { get; set; }
        public IEnumerable<Guernsey.Population.Changes> PopulationChanges { get; set; }
        public IEnumerable<District> PopulationDistrict { get; set; }
        public IEnumerable<Parish> PopulationParish { get; set; }
        public IEnumerable<Population> Population { get; set; }
        public IEnumerable<CondorPunctuality> SailingsCondorPunctuality { get; set; }
        public IEnumerable<Guernsey.Sailings.Cruises> SailingsCruises { get; set; }
        public IEnumerable<AirByMonth> TourismAirByMonth { get; set; }
        public IEnumerable<Guernsey.Tourism.Cruises> TourismCruises { get; set; }
        public IEnumerable<SeaByMonth> TourismSeaByMonth { get; set; }
        public IEnumerable<Traffic> Traffic { get; set; }
        public IEnumerable<TrafficClassifications> TrafficClassifications { get; set; }
        public IEnumerable<TrafficCollisions> TrafficCollisions { get; set; }
        public IEnumerable<TrafficInjuries> TrafficInjuries { get; set; }
        public IEnumerable<RegisteredVehicles> TransportRegisteredVehicles { get; set; }
        public IEnumerable<CommericalAndIndustrial> WasteCommercialAndIndustrial { get; set; }
        public IEnumerable<ConstructionAndDemolition> WasteConstructionAndDemolition { get; set; }
        public IEnumerable<Household> WasteHousehold { get; set; }
        public IEnumerable<DomesticConsumption> WaterDomesticConsumption { get; set; }
        public IEnumerable<NitrateConcentration> WaterNitrateConcentration { get; set; }
        public IEnumerable<PollutionIncidents> WaterPollutionIncidents { get; set; }
        public IEnumerable<UnaccountedWater> WaterUnaccounted { get; set; }
        public IEnumerable<WaterConsumption> WaterConsumption { get; set; }
        public IEnumerable<WaterQualityCompliance> WaterQualityCompliance { get; set; }
        public IEnumerable<WaterStorage> WaterStorage { get; set; }
        public IEnumerable<FrostDays> WeatherFrostDays { get; set; }
        public IEnumerable<MetOfficeAnnual> WeatherMetOfficeAnnual { get; set; }
        public IEnumerable<MetOfficeMonthly> WeatherMetOfficeMonthly { get; set; }
    }

}

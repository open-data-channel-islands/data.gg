using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
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
using DataGg.Core.Guernsey.Herm;
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
using Microsoft.Extensions.Configuration;

namespace DataGg.Database
{
    public class GuernseyDb : DatabaseBase
    {
        public GuernseyDb(IConfiguration configuration) : base(configuration) { }

        private string GetResourceTextFile(string filename)
        {
            using var stream = GetType().Assembly.GetManifestResourceStream($"DataGg.Database.Guernsey.{filename}");

            using var sr = new StreamReader(stream);

            return sr.ReadToEnd();
        }

        public async Task<BusUsage[]> GetBusUsage()
        {
            var json = GetResourceTextFile("buses.bus_usage.json");
            var busUsage = JsonSerializer.Deserialize<BusUsage[]>(json);
            return busUsage;
        }

        public async Task<HermTrident[]> GetHermTrident()
        {
            var json = GetResourceTextFile("Herm.herm_trident.json");
            var hermTrident = JsonSerializer.Deserialize<HermTrident[]>(json);
            return hermTrident;
        }

        public async Task<Crime[]> GetCrime()
        {
            var json = GetResourceTextFile("crime.crime.json");
            var Crime = JsonSerializer.Deserialize<Crime[]>(json);
            return Crime;
        }

        public async Task<PrisonPopulation[]> GetCrimePrisonPopulation()
        {
            var json = GetResourceTextFile("crime.prison_population.json");
            var prisonPopulation = JsonSerializer.Deserialize<PrisonPopulation[]>(json);
            return prisonPopulation;
        }

        public async Task<Worried[]> GetCrimeWorried()
        {
            var json = GetResourceTextFile("crime.worried.json");
            var Worried = JsonSerializer.Deserialize<Worried[]>(json);
            return Worried;
        }

        public async Task<EarningsAgeGroup[]> GetEarningsAgeGroup()
        {
            var json = GetResourceTextFile("earnings.earnings_age_group.json");
            var earningsAgeGroup = JsonSerializer.Deserialize<EarningsAgeGroup[]>(json);
            return earningsAgeGroup;
        }

        public async Task<EarningsSector[]> GetEducationEarningsSector()
        {
            var json = GetResourceTextFile("earnings.earnings_sector.json");
            var earningsSector = JsonSerializer.Deserialize<EarningsSector[]>(json);
            return earningsSector;
        }

        public async Task<EarningsSex[]> GetEducationEarningsSex()
        {
            var json = GetResourceTextFile("earnings.earnings_sex.json");
            var earningsSex = JsonSerializer.Deserialize<EarningsSex[]>(json);
            return earningsSex;
        }

        public async Task<GcseOverall[]> GetEducationGcseOverall()
        {
            var json = GetResourceTextFile("education.gcse_overall.json");
            var gcseOverall = JsonSerializer.Deserialize<GcseOverall[]>(json);
            return gcseOverall;
        }

        public async Task<GcseSchool[]> GetEducationGcseSchool()
        {
            var json = GetResourceTextFile("education.gcse_school.json");
            var gcseSchool = JsonSerializer.Deserialize<GcseSchool[]>(json);
            return gcseSchool;
        }

        public async Task<Post16Results[]> GetEducationPost16Results()
        {
            var json = GetResourceTextFile("education.post16results.json");
            var post16Results = JsonSerializer.Deserialize<Post16Results[]>(json);
            return post16Results;
        }

        public async Task<StudentsInUk[]> GetEducationStudentsInUk()
        {
            var json = GetResourceTextFile("education.students_in_uk.json");
            var studentsInUk = JsonSerializer.Deserialize<StudentsInUk[]>(json);
            return studentsInUk;
        }

        public async Task<Source[]> GetEmissionSource()
        {
            var json = GetResourceTextFile("emissions.source.json");
            var source = JsonSerializer.Deserialize<Source[]>(json);
            return source;
        }

        public async Task<Type[]> GetEmissionType()
        {
            var json = GetResourceTextFile("emissions.type.json");
            var type = JsonSerializer.Deserialize<Type[]>(json);
            return type;
        }

        public async Task<Sector[]> GetEmploymentSector()
        {
            var json = GetResourceTextFile("employment.sector.json");
            var sector = JsonSerializer.Deserialize<Sector[]>(json);
            return sector;
        }

        public async Task<Totals[]> GetEmploymentTotals()
        {
            var json = GetResourceTextFile("employment.totals.json");
            var totals = JsonSerializer.Deserialize<Totals[]>(json);
            return totals;
        }

        public async Task<Consumption[]> GetEnergyElectricityConsumption()
        {
            var json = GetResourceTextFile("energy.electricity_consumption.json");
            var electricityConsumption = JsonSerializer.Deserialize<Consumption[]>(json);
            return electricityConsumption;
        }

        public async Task<ImportedVsGenerated[]> GetEnergyElectricityImportVsGenerated()
        {
            var json = GetResourceTextFile("energy.electricity_import_vs_generated.json");
            var electricityImportVsGenerated = JsonSerializer.Deserialize<ImportedVsGenerated[]>(json);
            return electricityImportVsGenerated;
        }

        public async Task<Gas[]> GetEnergyGas()
        {
            var json = GetResourceTextFile("energy.gas.json");
            var gas = JsonSerializer.Deserialize<Gas[]>(json);
            return gas;
        }

        public async Task<OilImports[]> GetEnergyOilImports()
        {
            var json = GetResourceTextFile("energy.oil_imports.json");
            var oilImports = JsonSerializer.Deserialize<OilImports[]>(json);
            return oilImports;
        }

        public async Task<Renewable[]> GetEnergyRenewable()
        {
            var json = GetResourceTextFile("energy.renewable_energy.json");
            var renewableEnergy = JsonSerializer.Deserialize<Renewable[]>(json);
            return renewableEnergy;
        }

        public async Task<Banking[]> GetFinanceBanking()
        {
            var json = GetResourceTextFile("finance.banking.json");
            var banking = JsonSerializer.Deserialize<Banking[]>(json);
            return banking;
        }

        public async Task<FundsUnderManagement[]> GetFinanceFundsUnderManagement()
        {
            var json = GetResourceTextFile("finance.fundsundermanagement.json");
            var fundsUnderManagement = JsonSerializer.Deserialize<FundsUnderManagement[]>(json);
            return fundsUnderManagement;
        }

        public async Task<Attendances[]> GetFireAndRescueAttendances()
        {
            var json = GetResourceTextFile("fire_and_rescue.attendances.json");
            var attendances = JsonSerializer.Deserialize<Attendances[]>(json);
            return attendances;
        }

        public async Task<Breakdown[]> GetGovSpendingBreakdown()
        {
            var json = GetResourceTextFile("government_spending.breakdown.json");
            var breakdown = JsonSerializer.Deserialize<Breakdown[]>(json);
            return breakdown;
        }

        public async Task<Colours> GetGovSpendingColours()
        {
            var json = GetResourceTextFile("government_spending.colours.json");
            var colours = JsonSerializer.Deserialize<Colours>(json);
            return colours;
        }

        public async Task<ChestAndHeartConcerns[]> GetHealthChestAndHeartConcerns()
        {
            var json = GetResourceTextFile("health.chest_and_heart_concerns.json");
            var chestAndHeartConcerns = JsonSerializer.Deserialize<ChestAndHeartConcerns[]>(json);
            return chestAndHeartConcerns;
        }

        public async Task<ChestAndHeartTotals[]> GetHealthChestAndHeartTotals()
        {
            var json = GetResourceTextFile("health.chest_and_heart_totals.json");
            var chestAndHeartTotals = JsonSerializer.Deserialize<ChestAndHeartTotals[]>(json);
            return chestAndHeartTotals;
        }

        public async Task<MedUnitBedDaysFiveYrAvg[]> GetHealthMedUnitBedDaysFiveYrAvg()
        {
            var json = GetResourceTextFile("health.med_unit_bed_days_five_yr_avg.json");
            var medUnitBedDaysFiveYrAvg = JsonSerializer.Deserialize<MedUnitBedDaysFiveYrAvg[]>(json);
            return medUnitBedDaysFiveYrAvg;
        }

        public async Task<Bedroom[]> GetHouseBedrooms()
        {
            var json = GetResourceTextFile("houses.bedrooms.json");
            var bedrooms = JsonSerializer.Deserialize<Bedroom[]>(json);
            return bedrooms;
        }

        public async Task<LocalPrices[]> GetHouseLocalPrices()
        {
            var json = GetResourceTextFile("houses.local_prices.json");
            var localPrices = JsonSerializer.Deserialize<LocalPrices[]>(json);
            return localPrices;
        }

        public async Task<OpenPrices[]> GetHouseOpenPrices()
        {
            var json = GetResourceTextFile("houses.open_prices.json");
            var openPrices = JsonSerializer.Deserialize<OpenPrices[]>(json);
            return openPrices;
        }

        public async Task<Types[]> GetHouseTypes()
        {
            var json = GetResourceTextFile("houses.types.json");
            var types = JsonSerializer.Deserialize<Types[]>(json);
            return types;
        }

        public async Task<Units[]> GetHouseUnits()
        {
            var json = GetResourceTextFile("houses.units.json");
            var units = JsonSerializer.Deserialize<Units[]>(json);
            return units;
        }

        public async Task<Core.Guernsey.Inflation.Changes[]> GetInflationChanges()
        {
            var json = GetResourceTextFile("inflation.changes.json");
            var changes = JsonSerializer.Deserialize<Core.Guernsey.Inflation.Changes[]>(json);
            return changes;
        }

        public async Task<RpixGroupChanges[]> GetInflationRpixGroupChanges()
        {
            var json = GetResourceTextFile("inflation.rpix_group_changes.json");
            var rpixGroupChanges = JsonSerializer.Deserialize<RpixGroupChanges[]>(json);
            return rpixGroupChanges;
        }

        public async Task<RpiGroupChanges[]> GetInflationRpiGroupChanges()
        {
            var json = GetResourceTextFile("inflation.rpi_group_changes.json");
            var rpiGroupChanges = JsonSerializer.Deserialize<RpiGroupChanges[]>(json);
            return rpiGroupChanges;
        }

        public async Task<Contributions[]> GetOverseasContributions()
        {
            var json = GetResourceTextFile("overseas_aid.contributions.json");
            var contributions = JsonSerializer.Deserialize<Contributions[]>(json);
            return contributions;
        }

        public async Task<Age[]> GetPopulationAge()
        {
            var json = GetResourceTextFile("population.age.json");
            var age = JsonSerializer.Deserialize<Age[]>(json);
            return age;
        }

        public async Task<AgeFemale[]> GetPopulationAgeFemale()
        {
            var json = GetResourceTextFile("population.age_female.json");
            var ageFemale = JsonSerializer.Deserialize<AgeFemale[]>(json);
            return ageFemale;
        }

        public async Task<AgeMale[]> GetPopulationAgeMale()
        {
            var json = GetResourceTextFile("population.age_male.json");
            var ageMale = JsonSerializer.Deserialize<AgeMale[]>(json);
            return ageMale;
        }

        public async Task<Birthplace[]> GetPopulationBirthplace()
        {
            var json = GetResourceTextFile("population.birthplace.json");
            var birthplace = JsonSerializer.Deserialize<Birthplace[]>(json);
            return birthplace;
        }

        public async Task<Core.Guernsey.Population.Changes[]> GetPopulationChanges()
        {
            var json = GetResourceTextFile("population.changes.json");
            var changes = JsonSerializer.Deserialize<Core.Guernsey.Population.Changes[]>(json);
            return changes;
        }

        public async Task<District[]> GetPopulationDistrict()
        {
            var json = GetResourceTextFile("population.district.json");
            var district = JsonSerializer.Deserialize<District[]>(json);
            return district;
        }

        public async Task<Parish[]> GetPopulationParish()
        {
            var json = GetResourceTextFile("population.parish.json");
            var parish = JsonSerializer.Deserialize<Parish[]>(json);
            return parish;
        }

        public async Task<Population[]> GetPopulation()
        {
            var json = GetResourceTextFile("population.population.json");
            var population = JsonSerializer.Deserialize<Population[]>(json);
            return population;
        }

        public async Task<CondorPunctuality[]> GetSailingsCondorPunctuality()
        {
            var json = GetResourceTextFile("sailings.condor_punctuality.json");
            var condorPunctuality = JsonSerializer.Deserialize<CondorPunctuality[]>(json);
            return condorPunctuality;
        }

        public async Task<Core.Guernsey.Sailings.Cruises[]> GetSailingsCruises()
        {
            var json = GetResourceTextFile("sailings.cruises.json");
            var cruises = JsonSerializer.Deserialize<Core.Guernsey.Sailings.Cruises[]>(json);
            return cruises;
        }

        public async Task<AirByMonth[]> GetTourismAirByMonth()
        {
            var json = GetResourceTextFile("tourism.air_by_month.json");
            var airByMonth = JsonSerializer.Deserialize<AirByMonth[]>(json);
            return airByMonth;
        }

        public async Task<Core.Guernsey.Tourism.Cruises[]> GetTourismCruises()
        {
            var json = GetResourceTextFile("tourism.cruises.json");
            var cruises = JsonSerializer.Deserialize<Core.Guernsey.Tourism.Cruises[]>(json);
            return cruises;
        }

        public async Task<SeaByMonth[]> GetTourismSeaByMonth()
        {
            var json = GetResourceTextFile("tourism.sea_by_month.json");
            var seaByMonth = JsonSerializer.Deserialize<SeaByMonth[]>(json);
            return seaByMonth;
        }

        public async Task<Traffic[]> GetTraffic()
        {
            var json = GetResourceTextFile("traffic.traffic.json");
            var traffic = JsonSerializer.Deserialize<Traffic[]>(json);
            return traffic;
        }

        public async Task<TrafficClassifications[]> GetTrafficClassifications()
        {
            var json = GetResourceTextFile("traffic.traffic_classifications.json");
            var trafficClassifications = JsonSerializer.Deserialize<TrafficClassifications[]>(json);
            return trafficClassifications;
        }

        public async Task<TrafficCollisions[]> GetTrafficCollisions()
        {
            var json = GetResourceTextFile("traffic.traffic_collisions.json");
            var trafficCollisions = JsonSerializer.Deserialize<TrafficCollisions[]>(json);
            return trafficCollisions;
        }

        public async Task<TrafficInjuries[]> GetTrafficInjuries()
        {
            var json = GetResourceTextFile("traffic.traffic_injuries.json");
            var trafficInjuries = JsonSerializer.Deserialize<TrafficInjuries[]>(json);
            return trafficInjuries;
        }

        public async Task<RegisteredVehicles[]> GetTransportRegisteredVehicles()
        {
            var json = GetResourceTextFile("transport.registered_vehicles.json");
            var registeredVehicles = JsonSerializer.Deserialize<RegisteredVehicles[]>(json);
            return registeredVehicles;
        }

        public async Task<CommericalAndIndustrial[]> GetWasteCommercialAndIndustrialWaste()
        {
            var json = GetResourceTextFile("waste.commercial_and_industrial_waste.json");
            var commercialAndIndustrialWaste = JsonSerializer.Deserialize<CommericalAndIndustrial[]>(json);
            return commercialAndIndustrialWaste;
        }

        public async Task<ConstructionAndDemolition[]> GetWasteConstructionAndDemolition()
        {
            var json = GetResourceTextFile("waste.construction_and_demolition_waste.json");
            var constructionAndDemolitionWaste = JsonSerializer.Deserialize<ConstructionAndDemolition[]>(json);
            return constructionAndDemolitionWaste;
        }

        public async Task<Household[]> GetWasteHousehold()
        {
            var json = GetResourceTextFile("waste.household_waste.json");
            var householdWaste = JsonSerializer.Deserialize<Household[]>(json);
            return householdWaste;
        }

        public async Task<DomesticConsumption[]> GetWaterDomesticConsumption()
        {
            var json = GetResourceTextFile("water.domestic_consumption.json");
            var domesticConsumption = JsonSerializer.Deserialize<DomesticConsumption[]>(json);
            return domesticConsumption;
        }

        public async Task<NitrateConcentration[]> GetWaterNitrateConcentration()
        {
            var json = GetResourceTextFile("water.nitrate_concentration.json");
            var nitrateConcentration = JsonSerializer.Deserialize<NitrateConcentration[]>(json);
            return nitrateConcentration;
        }

        public async Task<PollutionIncidents[]> GetWaterPollutionIncidents()
        {
            var json = GetResourceTextFile("water.pollution_incidents.json");
            var pollutionIncidents = JsonSerializer.Deserialize<PollutionIncidents[]>(json);
            return pollutionIncidents;
        }

        public async Task<UnaccountedWater[]> GetWaterUnaccounted()
        {
            var json = GetResourceTextFile("water.unaccounted_water.json");
            var unaccountedWater = JsonSerializer.Deserialize<UnaccountedWater[]>(json);
            return unaccountedWater;
        }

        public async Task<WaterConsumption[]> GetWaterConsumption()
        {
            var json = GetResourceTextFile("water.water_consumption.json");
            var waterConsumption = JsonSerializer.Deserialize<WaterConsumption[]>(json);
            return waterConsumption;
        }

        public async Task<WaterQualityCompliance[]> GetWaterQualityCompliance()
        {
            var json = GetResourceTextFile("water.water_quality_compliance.json");
            var waterQualityCompliance = JsonSerializer.Deserialize<WaterQualityCompliance[]>(json);
            return waterQualityCompliance;
        }

        public async Task<WaterStorage[]> GetWaterStorage()
        {
            var json = GetResourceTextFile("water.water_storage.json");
            var waterStorage = JsonSerializer.Deserialize<WaterStorage[]>(json);
            return waterStorage;
        }

        public async Task<FrostDays[]> GetWeatherFrostDays()
        {
            var json = GetResourceTextFile("weather.frost_days.json");
            var frostDays = JsonSerializer.Deserialize<FrostDays[]>(json);
            return frostDays;
        }

        public async Task<MetOfficeAnnual[]> GetWeatherMetOfficeAnnual()
        {
            var json = GetResourceTextFile("weather.metoffice_annual_report.json");
            var metofficeAnnualReport = JsonSerializer.Deserialize<MetOfficeAnnual[]>(json);
            return metofficeAnnualReport;
        }

        public async Task<MetOfficeMonthly[]> GetWeatherMetOfficeMonthly()
        {
            var json = GetResourceTextFile("weather.metoffice_monthly_report.json");
            var metofficeMonthlyReport = JsonSerializer.Deserialize<MetOfficeMonthly[]>(json);
            return metofficeMonthlyReport;
        }
    }
}
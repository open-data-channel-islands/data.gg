using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Dapper;
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
using DataGg.Core.Types;
using Microsoft.Extensions.Configuration;

namespace DataGg.Database
{
    public class GuernseyDb : DatabaseBase
    {
        public GuernseyDb(IConfiguration configuration) : base(configuration) { }

        public async Task<DataCache> GetDataCache()
        {
            return new DataCache()
            {
                BusUsage = await GetBusUsage(),
                Crime = await GetCrime(),
                CrimePrisonPopulation = await GetCrimePrisonPopulation(),
                CrimeWorried = await GetCrimeWorried(),
                EarningsAgeGroup = await GetEarningsAgeGroup(),
                EducationEarningsSector = await GetEducationEarningsSector(),
                EducationEarningsSex = await GetEducationEarningsSex(),
                EducationGcseOverall = await GetEducationGcseOverall(),
                EducationGcseSchool = await GetEducationGcseSchool(),
                EducationPost16Results = await GetEducationPost16Results(),
                EducationStudentsInUk = await GetEducationStudentsInUk(),
                EmissionSource = await GetEmissionSource(),
                EmissionType = await GetEmissionType(),
                EmploymentSector = await GetEmploymentSector(),
                EmploymentTotals = await GetEmploymentTotals(),
                EnergyElectricityConsumption = await GetEnergyElectricityConsumption(),
                EnergyElectricityImportVsGenerated = await GetEnergyElectricityImportVsGenerated(),
                EnergyGas = await GetEnergyGas(),
                EnergyOilImports = await GetEnergyOilImports(),
                EnergyRenewable = await GetEnergyRenewable(),
                FinanceBanking = await GetFinanceBanking(),
                FinanceFundsUnderManagement = await GetFinanceFundsUnderManagement(),
                FireAndRescueAttendances = await GetFireAndRescueAttendances(),
                GovSpendingBreakdown = await GetGovSpendingBreakdown(),
                HealthChestAndHeartConcerns = await GetHealthChestAndHeartConcerns(),
                HealthChestAndHeartTotals = await GetHealthChestAndHeartTotals(),
                HealthMedUnitBedDaysFiveYrAvg = await GetHealthMedUnitBedDaysFiveYrAvg(),
                HouseBedrooms = await GetHouseBedrooms(),
                HouseLocalPrices = await GetHouseLocalPrices(),
                HouseOpenPrices = await GetHouseOpenPrices(),
                HouseTypes = await GetHouseTypes(),
                HouseUnits = await GetHouseUnits(),
                InflationChanges = await GetInflationChanges(),
                InflationRpixGroupChanges = await GetInflationRpixGroupChanges(),
                InflationRpiGroupChanges = await GetInflationRpiGroupChanges(),
                OverseasContributions = await GetOverseasContributions(),
                PopulationAge = await GetPopulationAge(),
                PopulationAgeFemale = await GetPopulationAgeFemale(),
                PopulationAgeMale = await GetPopulationAgeMale(),
                PopulationBirthplace = await GetPopulationBirthplace(),
                PopulationChanges = await GetPopulationChanges(),
                PopulationDistrict = await GetPopulationDistrict(),
                PopulationParish = await GetPopulationParish(),
                Population = await GetPopulation(),
                SailingsCondorPunctuality = await GetSailingsCondorPunctuality(),
                SailingsCruises = await GetSailingsCruises(),
                TourismAirByMonth = await GetTourismAirByMonth(),
                TourismCruises = await GetTourismCruises(),
                TourismSeaByMonth = await GetTourismSeaByMonth(),
                Traffic = await GetTraffic(),
                TrafficClassifications = await GetTrafficClassifications(),
                TrafficCollisions = await GetTrafficCollisions(),
                TrafficInjuries = await GetTrafficInjuries(),
                TransportRegisteredVehicles = await GetTransportRegisteredVehicles(),
                WasteCommercialAndIndustrial = await GetWasteCommercialAndIndustrialWaste(),
                WasteConstructionAndDemolition = await GetWasteConstructionAndDemolition(),
                WasteHousehold = await GetWasteHousehold(),
                WaterDomesticConsumption = await GetWaterDomesticConsumption(),
                WaterNitrateConcentration = await GetWaterNitrateConcentration(),
                WaterPollutionIncidents = await GetWaterPollutionIncidents(),
                WaterUnaccounted = await GetWaterUnaccounted(),
                WaterConsumption = await GetWaterConsumption(),
                WaterQualityCompliance = await GetWaterQualityCompliance(),
                WaterStorage = await GetWaterStorage(),
                WeatherFrostDays = await GetWeatherFrostDays(),
                WeatherMetOfficeAnnual = await GetWeatherMetOfficeAnnual(),
                WeatherMetOfficeMonthly = await GetWeatherMetOfficeMonthly(),
            };
        }

        private async Task<string> GetJsonFromDb(string filename)
        {
            await using var conn = await OpenConnectionAsync();

            var dataJson = await conn.QueryFirstOrDefaultAsync<DataJson>("dbo.GetDataJson",
                new { filename },
                commandType: System.Data.CommandType.StoredProcedure);

            return dataJson.Json;
        }

        public async Task<BusUsage[]> GetBusUsage()
        {
            var json = await GetJsonFromDb("buses/bus_usage.json");
            var busUsage = JsonSerializer.Deserialize<BusUsage[]>(json);
            return busUsage;
        }

        public async Task<Crime[]> GetCrime()
        {
            var json = await GetJsonFromDb("crime/crime.json");
            var Crime = JsonSerializer.Deserialize<Crime[]>(json);
            return Crime;
        }

        public async Task<PrisonPopulation[]> GetCrimePrisonPopulation()
        {
            var json = await GetJsonFromDb("crime/prison_population.json");
            var prisonPopulation = JsonSerializer.Deserialize<PrisonPopulation[]>(json);
            return prisonPopulation;
        }

        public async Task<Worried[]> GetCrimeWorried()
        {
            var json = await GetJsonFromDb("crime/worried.json");
            var Worried = JsonSerializer.Deserialize<Worried[]>(json);
            return Worried;
        }

        public async Task<EarningsAgeGroup[]> GetEarningsAgeGroup()
        {
            var json = await GetJsonFromDb("earnings/earnings_age_group.json");
            var earningsAgeGroup = JsonSerializer.Deserialize<EarningsAgeGroup[]>(json);
            return earningsAgeGroup;
        }

        public async Task<EarningsSector[]> GetEducationEarningsSector()
        {
            var json = await GetJsonFromDb("earnings/earnings_sector.json");
            var earningsSector = JsonSerializer.Deserialize<EarningsSector[]>(json);
            return earningsSector;
        }

        public async Task<EarningsSex[]> GetEducationEarningsSex()
        {
            var json = await GetJsonFromDb("earnings/earnings_sex.json");
            var earningsSex = JsonSerializer.Deserialize<EarningsSex[]>(json);
            return earningsSex;
        }

        public async Task<GcseOverall[]> GetEducationGcseOverall()
        {
            var json = await GetJsonFromDb("education/gcse_overall.json");
            var gcseOverall = JsonSerializer.Deserialize<GcseOverall[]>(json);
            return gcseOverall;
        }

        public async Task<GcseSchool[]> GetEducationGcseSchool()
        {
            var json = await GetJsonFromDb("education/gcse_school.json");
            var gcseSchool = JsonSerializer.Deserialize<GcseSchool[]>(json);
            return gcseSchool;
        }

        public async Task<Post16Results[]> GetEducationPost16Results()
        {
            var json = await GetJsonFromDb("education/post16results.json");
            var post16Results = JsonSerializer.Deserialize<Post16Results[]>(json);
            return post16Results;
        }

        public async Task<StudentsInUk[]> GetEducationStudentsInUk()
        {
            var json = await GetJsonFromDb("education/students_in_uk.json");
            var studentsInUk = JsonSerializer.Deserialize<StudentsInUk[]>(json);
            return studentsInUk;
        }

        public async Task<Source[]> GetEmissionSource()
        {
            var json = await GetJsonFromDb("emissions/source.json");
            var source = JsonSerializer.Deserialize<Source[]>(json);
            return source;
        }

        public async Task<Type[]> GetEmissionType()
        {
            var json = await GetJsonFromDb("emissions/type.json");
            var type = JsonSerializer.Deserialize<Type[]>(json);
            return type;
        }

        public async Task<Sector[]> GetEmploymentSector()
        {
            var json = await GetJsonFromDb("employment/sectors.json");
            var sector = JsonSerializer.Deserialize<Sector[]>(json);
            return sector;
        }

        public async Task<Totals[]> GetEmploymentTotals()
        {
            var json = await GetJsonFromDb("employment/totals.json");
            var totals = JsonSerializer.Deserialize<Totals[]>(json);
            return totals;
        }

        public async Task<Consumption[]> GetEnergyElectricityConsumption()
        {
            var json = await GetJsonFromDb("energy/electricity_consumption.json");
            var electricityConsumption = JsonSerializer.Deserialize<Consumption[]>(json);
            return electricityConsumption;
        }

        public async Task<ImportedVsGenerated[]> GetEnergyElectricityImportVsGenerated()
        {
            var json = await GetJsonFromDb("energy/electricity_import_vs_generated.json");
            var electricityImportVsGenerated = JsonSerializer.Deserialize<ImportedVsGenerated[]>(json);
            return electricityImportVsGenerated;
        }

        public async Task<Gas[]> GetEnergyGas()
        {
            var json = await GetJsonFromDb("energy/gas.json");
            var gas = JsonSerializer.Deserialize<Gas[]>(json);
            return gas;
        }

        public async Task<OilImports[]> GetEnergyOilImports()
        {
            var json = await GetJsonFromDb("energy/oil_imports.json");
            var oilImports = JsonSerializer.Deserialize<OilImports[]>(json);
            return oilImports;
        }

        public async Task<Renewable[]> GetEnergyRenewable()
        {
            var json = await GetJsonFromDb("energy/renewable_energy.json");
            var renewableEnergy = JsonSerializer.Deserialize<Renewable[]>(json);
            return renewableEnergy;
        }

        public async Task<Banking[]> GetFinanceBanking()
        {
            var json = await GetJsonFromDb("finance/banking.json");
            var banking = JsonSerializer.Deserialize<Banking[]>(json);
            return banking;
        }

        public async Task<FundsUnderManagement[]> GetFinanceFundsUnderManagement()
        {
            var json = await GetJsonFromDb("finance/fundsundermanagement.json");
            var fundsUnderManagement = JsonSerializer.Deserialize<FundsUnderManagement[]>(json);
            return fundsUnderManagement;
        }

        public async Task<Attendances[]> GetFireAndRescueAttendances()
        {
            var json = await GetJsonFromDb("fire_and_rescue/attendances.json");
            var attendances = JsonSerializer.Deserialize<Attendances[]>(json);
            return attendances;
        }

        public async Task<Breakdown[]> GetGovSpendingBreakdown()
        {
            var json = await GetJsonFromDb("government_spending/breakdown.json");
            var breakdown = JsonSerializer.Deserialize<Breakdown[]>(json);
            return breakdown;
        }

        public async Task<ChestAndHeartConcerns[]> GetHealthChestAndHeartConcerns()
        {
            var json = await GetJsonFromDb("health/chest_and_heart_concerns.json");
            var chestAndHeartConcerns = JsonSerializer.Deserialize<ChestAndHeartConcerns[]>(json);
            return chestAndHeartConcerns;
        }

        public async Task<ChestAndHeartTotals[]> GetHealthChestAndHeartTotals()
        {
            var json = await GetJsonFromDb("health/chest_and_heart_totals.json");
            var chestAndHeartTotals = JsonSerializer.Deserialize<ChestAndHeartTotals[]>(json);
            return chestAndHeartTotals;
        }

        public async Task<MedUnitBedDaysFiveYrAvg[]> GetHealthMedUnitBedDaysFiveYrAvg()
        {
            var json = await GetJsonFromDb("health/med_unit_bed_days_five_yr_avg.json");
            var medUnitBedDaysFiveYrAvg = JsonSerializer.Deserialize<MedUnitBedDaysFiveYrAvg[]>(json);
            return medUnitBedDaysFiveYrAvg;
        }

        public async Task<Bedroom[]> GetHouseBedrooms()
        {
            var json = await GetJsonFromDb("houses/bedrooms.json");
            var bedrooms = JsonSerializer.Deserialize<Bedroom[]>(json);
            return bedrooms;
        }

        public async Task<LocalPrices[]> GetHouseLocalPrices()
        {
            var json = await GetJsonFromDb("houses/local_prices.json");
            var localPrices = JsonSerializer.Deserialize<LocalPrices[]>(json);
            return localPrices;
        }

        public async Task<OpenPrices[]> GetHouseOpenPrices()
        {
            var json = await GetJsonFromDb("houses/open_prices.json");
            var openPrices = JsonSerializer.Deserialize<OpenPrices[]>(json);
            return openPrices;
        }

        public async Task<Types[]> GetHouseTypes()
        {
            var json = await GetJsonFromDb("houses/types.json");
            var types = JsonSerializer.Deserialize<Types[]>(json);
            return types;
        }

        public async Task<Units[]> GetHouseUnits()
        {
            var json = await GetJsonFromDb("houses/units.json");
            var units = JsonSerializer.Deserialize<Units[]>(json);
            return units;
        }

        public async Task<Core.Guernsey.Inflation.Changes[]> GetInflationChanges()
        {
            var json = await GetJsonFromDb("inflation/changes.json");
            var changes = JsonSerializer.Deserialize<Core.Guernsey.Inflation.Changes[]>(json);
            return changes;
        }

        public async Task<RpixGroupChanges[]> GetInflationRpixGroupChanges()
        {
            var json = await GetJsonFromDb("inflation/rpix_group_changes.json");
            var rpixGroupChanges = JsonSerializer.Deserialize<RpixGroupChanges[]>(json);
            return rpixGroupChanges;
        }

        public async Task<RpiGroupChanges[]> GetInflationRpiGroupChanges()
        {
            var json = await GetJsonFromDb("inflation/rpi_group_changes.json");
            var rpiGroupChanges = JsonSerializer.Deserialize<RpiGroupChanges[]>(json);
            return rpiGroupChanges;
        }

        public async Task<Contributions[]> GetOverseasContributions()
        {
            var json = await GetJsonFromDb("overseas_aid/contributions.json");
            var contributions = JsonSerializer.Deserialize<Contributions[]>(json);
            return contributions;
        }

        public async Task<Age[]> GetPopulationAge()
        {
            var json = await GetJsonFromDb("population/age.json");
            var age = JsonSerializer.Deserialize<Age[]>(json);
            return age;
        }

        public async Task<AgeFemale[]> GetPopulationAgeFemale()
        {
            var json = await GetJsonFromDb("population/age_female.json");
            var ageFemale = JsonSerializer.Deserialize<AgeFemale[]>(json);
            return ageFemale;
        }

        public async Task<AgeMale[]> GetPopulationAgeMale()
        {
            var json = await GetJsonFromDb("population/age_male.json");
            var ageMale = JsonSerializer.Deserialize<AgeMale[]>(json);
            return ageMale;
        }

        public async Task<Birthplace[]> GetPopulationBirthplace()
        {
            var json = await GetJsonFromDb("population/birthplace.json");
            var birthplace = JsonSerializer.Deserialize<Birthplace[]>(json);
            return birthplace;
        }

        public async Task<Core.Guernsey.Population.Changes[]> GetPopulationChanges()
        {
            var json = await GetJsonFromDb("population/changes.json");
            var changes = JsonSerializer.Deserialize<Core.Guernsey.Population.Changes[]>(json);
            return changes;
        }

        public async Task<District[]> GetPopulationDistrict()
        {
            var json = await GetJsonFromDb("population/district.json");
            var district = JsonSerializer.Deserialize<District[]>(json);
            return district;
        }

        public async Task<Parish[]> GetPopulationParish()
        {
            var json = await GetJsonFromDb("population/parish.json");
            var parish = JsonSerializer.Deserialize<Parish[]>(json);
            return parish;
        }

        public async Task<Population[]> GetPopulation()
        {
            var json = await GetJsonFromDb("population/population.json");
            var population = JsonSerializer.Deserialize<Population[]>(json);
            return population;
        }

        public async Task<CondorPunctuality[]> GetSailingsCondorPunctuality()
        {
            var json = await GetJsonFromDb("sailings/condor_punctuality.json");
            var condorPunctuality = JsonSerializer.Deserialize<CondorPunctuality[]>(json);
            return condorPunctuality;
        }

        public async Task<Core.Guernsey.Sailings.Cruises[]> GetSailingsCruises()
        {
            var json = await GetJsonFromDb("sailings/cruises.json");
            var cruises = JsonSerializer.Deserialize<Core.Guernsey.Sailings.Cruises[]>(json);
            return cruises;
        }

        public async Task<AirByMonth[]> GetTourismAirByMonth()
        {
            var json = await GetJsonFromDb("tourism/air_by_month.json");
            var airByMonth = JsonSerializer.Deserialize<AirByMonth[]>(json);
            return airByMonth;
        }

        public async Task<Core.Guernsey.Tourism.Cruises[]> GetTourismCruises()
        {
            var json = await GetJsonFromDb("tourism/cruises.json");
            var cruises = JsonSerializer.Deserialize<Core.Guernsey.Tourism.Cruises[]>(json);
            return cruises;
        }

        public async Task<SeaByMonth[]> GetTourismSeaByMonth()
        {
            var json = await GetJsonFromDb("tourism/sea_by_month.json");
            var seaByMonth = JsonSerializer.Deserialize<SeaByMonth[]>(json);
            return seaByMonth;
        }

        public async Task<Traffic[]> GetTraffic()
        {
            var json = await GetJsonFromDb("traffic/traffic.json");
            var traffic = JsonSerializer.Deserialize<Traffic[]>(json);
            return traffic;
        }

        public async Task<TrafficClassifications[]> GetTrafficClassifications()
        {
            var json = await GetJsonFromDb("traffic/traffic_classifications.json");
            var trafficClassifications = JsonSerializer.Deserialize<TrafficClassifications[]>(json);
            return trafficClassifications;
        }

        public async Task<TrafficCollisions[]> GetTrafficCollisions()
        {
            var json = await GetJsonFromDb("traffic/traffic_collisions.json");
            var trafficCollisions = JsonSerializer.Deserialize<TrafficCollisions[]>(json);
            return trafficCollisions;
        }

        public async Task<TrafficInjuries[]> GetTrafficInjuries()
        {
            var json = await GetJsonFromDb("traffic/traffic_injuries.json");
            var trafficInjuries = JsonSerializer.Deserialize<TrafficInjuries[]>(json);
            return trafficInjuries;
        }

        public async Task<RegisteredVehicles[]> GetTransportRegisteredVehicles()
        {
            var json = await GetJsonFromDb("transport/registered_vehicles.json");
            var registeredVehicles = JsonSerializer.Deserialize<RegisteredVehicles[]>(json);
            return registeredVehicles;
        }

        public async Task<CommericalAndIndustrial[]> GetWasteCommercialAndIndustrialWaste()
        {
            var json = await GetJsonFromDb("waste/commercial_and_industrial_waste.json");
            var commercialAndIndustrialWaste = JsonSerializer.Deserialize<CommericalAndIndustrial[]>(json);
            return commercialAndIndustrialWaste;
        }

        public async Task<ConstructionAndDemolition[]> GetWasteConstructionAndDemolition()
        {
            var json = await GetJsonFromDb("waste/construction_and_demolition_waste.json");
            var constructionAndDemolitionWaste = JsonSerializer.Deserialize<ConstructionAndDemolition[]>(json);
            return constructionAndDemolitionWaste;
        }

        public async Task<Household[]> GetWasteHousehold()
        {
            var json = await GetJsonFromDb("waste/household_waste.json");
            var householdWaste = JsonSerializer.Deserialize<Household[]>(json);
            return householdWaste;
        }

        public async Task<DomesticConsumption[]> GetWaterDomesticConsumption()
        {
            var json = await GetJsonFromDb("water/domestic_consumption.json");
            var domesticConsumption = JsonSerializer.Deserialize<DomesticConsumption[]>(json);
            return domesticConsumption;
        }

        public async Task<NitrateConcentration[]> GetWaterNitrateConcentration()
        {
            var json = await GetJsonFromDb("water/nitrate_concentration.json");
            var nitrateConcentration = JsonSerializer.Deserialize<NitrateConcentration[]>(json);
            return nitrateConcentration;
        }

        public async Task<PollutionIncidents[]> GetWaterPollutionIncidents()
        {
            var json = await GetJsonFromDb("water/pollution_incidents.json");
            var pollutionIncidents = JsonSerializer.Deserialize<PollutionIncidents[]>(json);
            return pollutionIncidents;
        }

        public async Task<UnaccountedWater[]> GetWaterUnaccounted()
        {
            var json = await GetJsonFromDb("water/unaccounted_water.json");
            var unaccountedWater = JsonSerializer.Deserialize<UnaccountedWater[]>(json);
            return unaccountedWater;
        }

        public async Task<WaterConsumption[]> GetWaterConsumption()
        {
            var json = await GetJsonFromDb("water/water_consumption.json");
            var waterConsumption = JsonSerializer.Deserialize<WaterConsumption[]>(json);
            return waterConsumption;
        }

        public async Task<WaterQualityCompliance[]> GetWaterQualityCompliance()
        {
            var json = await GetJsonFromDb("water/water_quality_compliance.json");
            var waterQualityCompliance = JsonSerializer.Deserialize<WaterQualityCompliance[]>(json);
            return waterQualityCompliance;
        }

        public async Task<WaterStorage[]> GetWaterStorage()
        {
            var json = await GetJsonFromDb("water/water_storage.json");
            var waterStorage = JsonSerializer.Deserialize<WaterStorage[]>(json);
            return waterStorage;
        }

        public async Task<FrostDays[]> GetWeatherFrostDays()
        {
            var json = await GetJsonFromDb("weather/frost_days.json");
            var frostDays = JsonSerializer.Deserialize<FrostDays[]>(json);
            return frostDays;
        }

        public async Task<MetOfficeAnnual[]> GetWeatherMetOfficeAnnual()
        {
            var json = await GetJsonFromDb("weather/metoffice_annual_report.json");
            var metofficeAnnualReport = JsonSerializer.Deserialize<MetOfficeAnnual[]>(json);
            return metofficeAnnualReport;
        }

        public async Task<MetOfficeMonthly[]> GetWeatherMetOfficeMonthly()
        {
            var json = await GetJsonFromDb("weather/metoffice_monthly_report.json");
            var metofficeMonthlyReport = JsonSerializer.Deserialize<MetOfficeMonthly[]>(json);
            return metofficeMonthlyReport;
        }
    }
}
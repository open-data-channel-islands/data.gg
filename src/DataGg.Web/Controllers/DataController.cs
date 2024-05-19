using DataGg.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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
using DataGg.Core.Guernsey.Flights;

namespace DataGg.Web.Controllers
{
    [Route("api")]
    [Route("api/1.1")]
    [Route("api/1.0")]
    [Route("api/v1")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly CacheManager _cacheManager;

        public DataController(CacheManager cacheManager)
        {
            _cacheManager = cacheManager;
        }

        [HttpGet]
        [Route("government-spending/breakdown")]
        [Route("government-spending/breakdown.json")]
        public async Task<IEnumerable<Breakdown>> GovernmentSpendingBreakdown()
        {
            var dataCache = await _cacheManager.DataCache.Get();

            return dataCache.GovSpendingBreakdown;
        }

        [HttpGet]
        [Route("buses/usage")]
        [Route("buses/usage.json")]
        public async Task<IEnumerable<BusUsage>> BusesUsage()
        {
            var dataCache = await _cacheManager.DataCache.Get();

            return dataCache.BusUsage;
        }

        [HttpGet]
        [Route("crime/crimes")]
        [Route("crime/crimes.json")]
        public async Task<IEnumerable<Crime>> CrimeCrimes()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.Crime;
        }

        [HttpGet]
        [Route("crime/prison_population")]
        [Route("crime/prison_population.json")]
        public async Task<IEnumerable<PrisonPopulation>> CrimePrisonPopulation()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.CrimePrisonPopulation;
        }

        [HttpGet]
        [Route("crime/worried")]
        [Route("crime/worried.json")]
        public async Task<IEnumerable<Worried>> CrimeWorried()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.CrimeWorried;
        }

        [HttpGet]
        [Route("earnings/earnings_age_group")]
        [Route("earnings/earnings_age_group.json")]
        public async Task<IEnumerable<EarningsAgeGroup>> EarningsEarningsAgeGroup()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EarningsAgeGroup;
        }

        [HttpGet]
        [Route("earnings/earnings_sector")]
        [Route("earnings/earnings_sector.json")]
        public async Task<IEnumerable<EarningsSector>> EarningsEarningsSector()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EarningsSector;
        }

        [HttpGet]
        [Route("earnings/earnings_sex")]
        [Route("earnings/earnings_sex.json")]
        public async Task<IEnumerable<EarningsSex>> EarningsEarningsSex()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EarningsSex;
        }

        [HttpGet]
        [Route("education/gcse_overall")]
        [Route("education/gcse_overall.json")]
        public async Task<IEnumerable<GcseOverall>> EducationGcseOverall()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EducationGcseOverall;
        }

        [HttpGet]
        [Route("education/gcse_school")]
        [Route("education/gcse_school.json")]
        public async Task<IEnumerable<GcseSchool>> EducationGcseSchool()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EducationGcseSchool;
        }

        [HttpGet]
        [Route("education/post16results")]
        [Route("education/post16results.json")]
        public async Task<IEnumerable<Post16Results>> EducationPost16Results()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EducationPost16Results;
        }

        [HttpGet]
        [Route("education/students_in_uk")]
        [Route("education/students_in_uk.json")]
        public async Task<IEnumerable<StudentsInUk>> EducationStudentsInUk()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EducationStudentsInUk;
        }

        [HttpGet]
        [Route("emissions/source")]
        [Route("emissions/source.json")]
        public async Task<IEnumerable<Source>> EmissionsSource()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EmissionSource;
        }

        [HttpGet]
        [Route("emissions/types")]
        [Route("emissions/types.json")]
        public async Task<IEnumerable<Type>> EmissionsTypes()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EmissionType;
        }

        [HttpGet]
        [Route("employment/sector")]
        [Route("employment/sector.json")]
        public async Task<IEnumerable<Sector>> EmploymentSectors()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EmploymentSector;
        }

        [HttpGet]
        [Route("employment/totals")]
        [Route("employment/totals.json")]
        public async Task<IEnumerable<Totals>> EmploymentTotals()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EmploymentTotals;
        }

        [HttpGet]
        [Route("energy/electricity_consumption")]
        [Route("energy/electricity_consumption.json")]
        public async Task<IEnumerable<Consumption>> EnergyElectricityConsumption()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EnergyElectricityConsumption;
        }

        [HttpGet]
        [Route("energy/electricity_import_vs_generated")]
        [Route("energy/electricity_import_vs_generated.json")]
        public async Task<IEnumerable<ImportedVsGenerated>> EnergyElectricityImportVsGenerated()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EnergyElectricityImportVsGenerated;
        }

        [HttpGet]
        [Route("energy/gas")]
        [Route("energy/gas.json")]
        public async Task<IEnumerable<Gas>> EnergyGas()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EnergyGas;
        }

        [HttpGet]
        [Route("energy/oil")]
        [Route("energy/oil.json")]
        public async Task<IEnumerable<OilImports>> EnergyOil()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EnergyOilImports;
        }

        [HttpGet]
        [Route("energy/renewable")]
        [Route("energy/renewable.json")]
        public async Task<IEnumerable<Renewable>> EnergyRenewable()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.EnergyRenewable;
        }

        [HttpGet]
        [Route("finance/banking")]
        [Route("finance/banking.json")]
        public async Task<IEnumerable<Banking>> FinanceBanking()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.FinanceBanking;
        }

        [HttpGet]
        [Route("finance/funds_under_management")]
        [Route("finance/funds_under_management.json")]
        public async Task<IEnumerable<FundsUnderManagement>> FinanceFundsUnderManagement()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.FinanceFundsUnderManagement;
        }

        [HttpGet]
        [Route("fire_and_rescue/attendances")]
        [Route("fire_and_rescue/attendances.json")]
        public async Task<IEnumerable<Attendances>> FireAndRescueAttendances()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.FireAndRescueAttendances;
        }

/*        [HttpGet]
        [Route("")]
        [Route("")]
        public async Task<IEnumerable<Breakdown>> GovSpendingBreakdown()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.GovSpendingBreakdown;
        }
        [HttpGet]
        [Route("")]
        [Route("")]
        public async Task<Colours> GovSpendingColours()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.GovSpendingColours;
        }*/
        [HttpGet]
        [Route("health/concerns")]
        [Route("health/concerns.json")]
        public async Task<IEnumerable<ChestAndHeartConcerns>> HealthConcerns()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.HealthChestAndHeartConcerns;
        }

        [HttpGet]
        [Route("health/totals")]
        [Route("health/totals.json")]
        public async Task<IEnumerable<ChestAndHeartTotals>> HealthTotals()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.HealthChestAndHeartTotals;
        }

        [HttpGet]
        [Route("health/med_unit_bed_days_five_yr_avg")]
        [Route("health/med_unit_bed_days_five_yr_avg.json")]
        public async Task<IEnumerable<MedUnitBedDaysFiveYrAvg>> HealthMedUnitBedDaysFiveYrAvg()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.HealthMedUnitBedDaysFiveYrAvg;
        }

        [HttpGet]
        [Route("health/medical_unit_bed_days")]
        [Route("health/medical_unit_bed_days.json")]
        public async Task<IEnumerable<MedicalUnitBedDays>> HealthMedicalUnitBedDays()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.HealthMedicalUnitBedDays;
        }

        [HttpGet]
        [Route("housing/bedrooms")]
        [Route("housing/bedrooms.json")]
        public async Task<IEnumerable<Bedroom>> HousingBedrooms()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.HouseBedrooms;
        }

        [HttpGet]
        [Route("housing/local_prices")]
        [Route("housing/local_prices.json")]
        public async Task<IEnumerable<LocalPrices>> HousingLocalPrices()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.HouseLocalPrices;
        }

        [HttpGet]
        [Route("housing/open_prices")]
        [Route("housing/open_prices.json")]
        public async Task<IEnumerable<OpenPrices>> HousingOpenPrices()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.HouseOpenPrices;
        }

        [HttpGet]
        [Route("housing/types")]
        [Route("housing/types.json")]
        public async Task<IEnumerable<Types>> HousingTypes()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.HouseTypes;
        }

        [HttpGet]
        [Route("housing/units")]
        [Route("housing/units.json")]
        public async Task<IEnumerable<Units>> HousingUnits()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.HouseUnits;
        }

        [HttpGet]
        [Route("inflation/changes")]
        [Route("inflation/changes.json")]
        public async Task<IEnumerable<Core.Guernsey.Inflation.Changes>> InflationChanges()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.InflationChanges;
        }

        [HttpGet]
        [Route("inflation/rpix_group_changes")]
        [Route("inflation/rpix_group_changes.json")]
        public async Task<IEnumerable<RpixGroupChanges>> InflationRpixGroupChanges()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.InflationRpixGroupChanges;
        }

        [HttpGet]
        [Route("inflation/rpi_group_changes")]
        [Route("inflation/rpi_group_changes.json")]
        public async Task<IEnumerable<RpiGroupChanges>> InflationRpiGroupChanges()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.InflationRpiGroupChanges;
        }

        [HttpGet]
        [Route("overseas_aid/contributions")]
        [Route("overseas_aid/contributions.json")]
        public async Task<IEnumerable<Contributions>> OverseasAidContributions()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.OverseasContributions;
        }

        [HttpGet]
        [Route("population/age")]
        [Route("population/age.json")]
        public async Task<IEnumerable<Age>> PopulationAge()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.PopulationAge;
        }

        [HttpGet]
        [Route("population/age_female")]
        [Route("population/age_female.json")]
        public async Task<IEnumerable<AgeFemale>> PopulationAgeFemale()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.PopulationAgeFemale;
        }

        [HttpGet]
        [Route("population/age_male")]
        [Route("population/age_male.json")]
        public async Task<IEnumerable<AgeMale>> PopulationAgeMale()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.PopulationAgeMale;
        }

        [HttpGet]
        [Route("population/birthplace")]
        [Route("population/birthplace.json")]
        public async Task<IEnumerable<Birthplace>> PopulationBirthplace()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.PopulationBirthplace;
        }

        [HttpGet]
        [Route("population/changes")]
        [Route("population/changes.json")]
        public async Task<IEnumerable<Core.Guernsey.Population.Changes>> PopulationChanges()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.PopulationChanges;
        }

        [HttpGet]
        [Route("population/district")]
        [Route("population/district.json")]
        public async Task<IEnumerable<District>> PopulationDistrict()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.PopulationDistrict;
        }

        [HttpGet]
        [Route("population/parish")]
        [Route("population/parish.json")]
        public async Task<IEnumerable<Parish>> PopulationParish()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.PopulationParish;
        }

        [HttpGet]
        [Route("population/population")]
        [Route("population/population.json")]
        public async Task<IEnumerable<Population>> PopulationPopulation()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.Population;
        }

        [HttpGet]
        [Route("sailings/condor_punctuality")]
        [Route("sailings/condor_punctuality.json")]
        public async Task<IEnumerable<CondorPunctuality>> SailingsCondorPunctuality()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.SailingsCondorPunctuality;
        }

        [HttpGet]
        [Route("sailings/cruises")]
        [Route("sailings/cruises.json")]
        public async Task<IEnumerable<Core.Guernsey.Sailings.Cruises>> SailingsCruises()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.SailingsCruises;
        }

        [HttpGet]
        [Route("tourism/air_by_month")]
        [Route("tourism/air_by_month.json")]
        public async Task<IEnumerable<AirByMonth>> TourismAirByMonth()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.TourismAirByMonth;
        }

        [HttpGet]
        [Route("tourism/cruises")]
        [Route("tourism/cruises.json")]
        public async Task<IEnumerable<Core.Guernsey.Tourism.Cruises>> TourismCruises()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.TourismCruises;
        }

        [HttpGet]
        [Route("tourism/sea_by_month")]
        [Route("tourism/sea_by_month.json")]
        public async Task<IEnumerable<SeaByMonth>> TourismSeaByMonth()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.TourismSeaByMonth;
        }

        [HttpGet]
        [Route("traffic/traffic")]
        [Route("traffic/traffic.json")]
        public async Task<IEnumerable<Traffic>> TrafficTraffic()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.Traffic;
        }

        [HttpGet]
        [Route("traffic/classifications")]
        [Route("traffic/classifications.json")]
        public async Task<IEnumerable<TrafficClassifications>> TrafficClassifications()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.TrafficClassifications;
        }

        [HttpGet]
        [Route("traffic/collisions")]
        [Route("traffic/collisions.json")]
        public async Task<IEnumerable<TrafficCollisions>> TrafficCollisions()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.TrafficCollisions;
        }

        [HttpGet]
        [Route("traffic/injuries")]
        [Route("traffic/injuries.json")]
        public async Task<IEnumerable<TrafficInjuries>> TrafficInjuries()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.TrafficInjuries;
        }

        [HttpGet]
        [Route("transport/registered_vehicles")]
        [Route("transport/registered_vehicles.json")]
        public async Task<IEnumerable<RegisteredVehicles>> TransportRegisteredVehicles()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.TransportRegisteredVehicles;
        }

        [HttpGet]
        [Route("waste/commercial-and-industrial")]
        [Route("waste/commercial-and-industrial.json")]
        public async Task<IEnumerable<CommericalAndIndustrial>> WasteCommercialAndIndustrial()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WasteCommercialAndIndustrial;
        }

        [HttpGet]
        [Route("waste/construction-and-demolition")]
        [Route("waste/construction-and-demolition.json")]
        public async Task<IEnumerable<ConstructionAndDemolition>> WasteConstructionAndDemolition()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WasteConstructionAndDemolition;
        }

        [HttpGet]
        [Route("waste/household")]
        [Route("waste/household.json")]
        public async Task<IEnumerable<Household>> WasteHousehold()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WasteHousehold;
        }

        [HttpGet]
        [Route("water/domestic_consumption")]
        [Route("water/domestic_consumption.json")]
        public async Task<IEnumerable<DomesticConsumption>> WaterDomesticConsumption()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WaterDomesticConsumption;
        }

        [HttpGet]
        [Route("water/nitrate-concentration")]
        [Route("water/nitrate-concentration.json")]
        public async Task<IEnumerable<NitrateConcentration>> WaterNitrateConcentration()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WaterNitrateConcentration;
        }

        [HttpGet]
        [Route("water/pollution-incidents")]
        [Route("water/pollution-incidents.json")]
        public async Task<IEnumerable<PollutionIncidents>> WaterPollutionIncidents()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WaterPollutionIncidents;
        }

        [HttpGet]
        [Route("water/unaccounted-water")]
        [Route("water/unaccounted-water.json")]
        public async Task<IEnumerable<UnaccountedWater>> WaterUnaccountedWater()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WaterUnaccounted;
        }

        [HttpGet]
        [Route("water/water-consumption")]
        [Route("water/water-consumption.json")]
        public async Task<IEnumerable<WaterConsumption>> WaterWaterConsumption()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WaterConsumption;
        }

        [HttpGet]
        [Route("water/water-quality-compliance")]
        [Route("water/water-quality-compliance.json")]
        public async Task<IEnumerable<WaterQualityCompliance>> WaterWaterQualityCompliance()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WaterQualityCompliance;
        }

        [HttpGet]
        [Route("water/water-storage")]
        [Route("water/water-storage.json")]
        public async Task<IEnumerable<WaterStorage>> WaterWaterStorage()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WaterStorage;
        }

        [HttpGet]
        [Route("weather/frost_days")]
        [Route("weather/frost_days.json")]
        public async Task<IEnumerable<FrostDays>> WeatherFrostDays()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WeatherFrostDays;
        }

        [HttpGet]
        [Route("weather/annual")]
        [Route("weather/annual.json")]
        public async Task<IEnumerable<MetOfficeAnnual>> WeatherAnnual()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WeatherMetOfficeAnnual;
        }

        [HttpGet]
        [Route("weather/monthly")]
        [Route("weather/monthly.json")]
        public async Task<IEnumerable<MetOfficeMonthly>> WeatherMonthly()
        {
            var dataCache = await _cacheManager.DataCache.Get();
            return dataCache.WeatherMetOfficeMonthly;
        }

        #region Live

        [HttpGet]
        [Route("flights/arrivals")]
        [Route("flights/arrivals.json")]
        public async Task<IEnumerable<Arrival>> FlightsArrivals()
        {
            var liveDataCache = await _cacheManager.GetLiveDataCache();
            return liveDataCache.AirportArrivals;
        }

        [HttpGet]
        [Route("flights/departures")]
        [Route("flights/departures.json")]
        public async Task<IEnumerable<Departure>> FlightsDepartures()
        {
            var liveDataCache = await _cacheManager.GetLiveDataCache();
            return liveDataCache.AirportDepartures;
        }

        [HttpGet]
        [Route("sailings/harbour")]
        [Route("sailings/harbour.json")]
        public async Task<IEnumerable<Harbour>> SailingsHarbour()
        {
            var liveDataCache = await _cacheManager.GetLiveDataCache();
            return liveDataCache.Harbour;
        }

        #endregion
    }
}
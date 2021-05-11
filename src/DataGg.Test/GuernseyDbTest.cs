using DataGg.Database;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace DataGg.Test
{
    [TestClass]
    public class GuernseyDbTest
    {
        private GuernseyDb _guernseyDb;

        [TestInitialize]
        public void Init()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.development.json")
                .Build();

            _guernseyDb = new GuernseyDb(config);
        }

        [TestMethod]
        public async Task BusUsage()
        {
            var busUsage = await _guernseyDb.GetBusUsage();

            Assert.IsNotNull(busUsage);
            Assert.IsTrue(busUsage.Length > 0);
        }

        [TestMethod]
        public async Task HermTrident()
        {
            var hermTrident = await _guernseyDb.GetHermTrident();

            Assert.IsNotNull(hermTrident);
            Assert.IsTrue(hermTrident.Length > 0);
        }

        [TestMethod]
        public async Task Crime()
        {
            var crime = await _guernseyDb.GetCrime();

            Assert.IsNotNull(crime);
            Assert.IsTrue(crime.Length > 0);
        }

        [TestMethod]
        public async Task CrimePrisonPopulation()
        {
            var crimePrisonPopulation = await _guernseyDb.GetCrimePrisonPopulation();

            Assert.IsNotNull(crimePrisonPopulation);
            Assert.IsTrue(crimePrisonPopulation.Length > 0);
        }

        [TestMethod]
        public async Task CrimeWorried()
        {
            var crimeWorried = await _guernseyDb.GetCrimeWorried();

            Assert.IsNotNull(crimeWorried);
            Assert.IsTrue(crimeWorried.Length > 0);
        }

        [TestMethod]
        public async Task EarningsAgeGroup()
        {
            var earningsAgeGroup = await _guernseyDb.GetEarningsAgeGroup();

            Assert.IsNotNull(earningsAgeGroup);
            Assert.IsTrue(earningsAgeGroup.Length > 0);
        }

        [TestMethod]
        public async Task EducationEarningsSector()
        {
            var educationEarningsSector = await _guernseyDb.GetEducationEarningsSector();

            Assert.IsNotNull(educationEarningsSector);
            Assert.IsTrue(educationEarningsSector.Length > 0);
        }

        [TestMethod]
        public async Task EducationEarningsSex()
        {
            var educationEarningsSex = await _guernseyDb.GetEducationEarningsSex();

            Assert.IsNotNull(educationEarningsSex);
            Assert.IsTrue(educationEarningsSex.Length > 0);
        }

        [TestMethod]
        public async Task EducationGcseOverall()
        {
            var educationGcseOverall = await _guernseyDb.GetEducationGcseOverall();

            Assert.IsNotNull(educationGcseOverall);
            Assert.IsTrue(educationGcseOverall.Length > 0);
        }

        [TestMethod]
        public async Task EducationGcseSchool()
        {
            var educationGcseSchool = await _guernseyDb.GetEducationGcseSchool();

            Assert.IsNotNull(educationGcseSchool);
            Assert.IsTrue(educationGcseSchool.Length > 0);
        }

        [TestMethod]
        public async Task EducationPost16Results()
        {
            var educationPost16Results = await _guernseyDb.GetEducationPost16Results();

            Assert.IsNotNull(educationPost16Results);
            Assert.IsTrue(educationPost16Results.Length > 0);
        }

        [TestMethod]
        public async Task EducationStudentsInUk()
        {
            var educationStudentsInUk = await _guernseyDb.GetEducationStudentsInUk();

            Assert.IsNotNull(educationStudentsInUk);
            Assert.IsTrue(educationStudentsInUk.Length > 0);
        }

        [TestMethod]
        public async Task EmissionSource()
        {
            var emissionSource = await _guernseyDb.GetEmissionSource();

            Assert.IsNotNull(emissionSource);
            Assert.IsTrue(emissionSource.Length > 0);
        }

        [TestMethod]
        public async Task EmissionType()
        {
            var emissionType = await _guernseyDb.GetEmissionType();

            Assert.IsNotNull(emissionType);
            Assert.IsTrue(emissionType.Length > 0);
        }

        [TestMethod]
        public async Task EmploymentSector()
        {
            var employmentSector = await _guernseyDb.GetEmploymentSector();

            Assert.IsNotNull(employmentSector);
            Assert.IsTrue(employmentSector.Length > 0);
        }

        [TestMethod]
        public async Task EmploymentTotals()
        {
            var employmentTotals = await _guernseyDb.GetEmploymentTotals();

            Assert.IsNotNull(employmentTotals);
            Assert.IsTrue(employmentTotals.Length > 0);
        }

        [TestMethod]
        public async Task EnergyElectricityConsumption()
        {
            var energyElectricityConsumption = await _guernseyDb.GetEnergyElectricityConsumption();

            Assert.IsNotNull(energyElectricityConsumption);
            Assert.IsTrue(energyElectricityConsumption.Length > 0);
        }

        [TestMethod]
        public async Task EnergyElectricityImportVsGenerated()
        {
            var energyElectricityImportVsGenerated = await _guernseyDb.GetEnergyElectricityImportVsGenerated();

            Assert.IsNotNull(energyElectricityImportVsGenerated);
            Assert.IsTrue(energyElectricityImportVsGenerated.Length > 0);
        }

        [TestMethod]
        public async Task EnergyGas()
        {
            var energyGas = await _guernseyDb.GetEnergyGas();

            Assert.IsNotNull(energyGas);
            Assert.IsTrue(energyGas.Length > 0);
        }

        [TestMethod]
        public async Task EnergyOilImports()
        {
            var energyOilImports = await _guernseyDb.GetEnergyOilImports();

            Assert.IsNotNull(energyOilImports);
            Assert.IsTrue(energyOilImports.Length > 0);
        }

        [TestMethod]
        public async Task EnergyRenewable()
        {
            var energyRenewable = await _guernseyDb.GetEnergyRenewable();

            Assert.IsNotNull(energyRenewable);
            Assert.IsTrue(energyRenewable.Length > 0);
        }

        [TestMethod]
        public async Task FinanceBanking()
        {
            var financeBanking = await _guernseyDb.GetFinanceBanking();

            Assert.IsNotNull(financeBanking);
            Assert.IsTrue(financeBanking.Length > 0);
        }

        [TestMethod]
        public async Task FinanceFundsUnderManagement()
        {
            var financeFundsUnderManagement = await _guernseyDb.GetFinanceFundsUnderManagement();

            Assert.IsNotNull(financeFundsUnderManagement);
            Assert.IsTrue(financeFundsUnderManagement.Length > 0);
        }

        [TestMethod]
        public async Task FireAndRescueAttendances()
        {
            var fireAndRescueAttendances = await _guernseyDb.GetFireAndRescueAttendances();

            Assert.IsNotNull(fireAndRescueAttendances);
            Assert.IsTrue(fireAndRescueAttendances.Length > 0);
        }

        [TestMethod]
        public async Task GovSpendingBreakdown()
        {
            var govSpendingBreakdown = await _guernseyDb.GetGovSpendingBreakdown();

            Assert.IsNotNull(govSpendingBreakdown);
            Assert.IsTrue(govSpendingBreakdown.Length > 0);
        }

        [TestMethod]
        public async Task GovSpendingColours()
        {
            var govSpendingColours = await _guernseyDb.GetGovSpendingColours();

            Assert.IsNotNull(govSpendingColours);
        }

        [TestMethod]
        public async Task HealthChestAndHeartConcerns()
        {
            var healthChestAndHeartConcerns = await _guernseyDb.GetHealthChestAndHeartConcerns();

            Assert.IsNotNull(healthChestAndHeartConcerns);
            Assert.IsTrue(healthChestAndHeartConcerns.Length > 0);
        }

        [TestMethod]
        public async Task HealthChestAndHeartTotals()
        {
            var healthChestAndHeartTotals = await _guernseyDb.GetHealthChestAndHeartTotals();

            Assert.IsNotNull(healthChestAndHeartTotals);
            Assert.IsTrue(healthChestAndHeartTotals.Length > 0);
        }

        [TestMethod]
        public async Task HealthMedUnitBedDaysFiveYrAvg()
        {
            var healthMedUnitBedDaysFiveYrAvg = await _guernseyDb.GetHealthMedUnitBedDaysFiveYrAvg();

            Assert.IsNotNull(healthMedUnitBedDaysFiveYrAvg);
            Assert.IsTrue(healthMedUnitBedDaysFiveYrAvg.Length > 0);
        }

        [TestMethod]
        public async Task HouseBedrooms()
        {
            var houseBedrooms = await _guernseyDb.GetHouseBedrooms();

            Assert.IsNotNull(houseBedrooms);
            Assert.IsTrue(houseBedrooms.Length > 0);
        }

        [TestMethod]
        public async Task HouseLocalPrices()
        {
            var houseLocalPrices = await _guernseyDb.GetHouseLocalPrices();

            Assert.IsNotNull(houseLocalPrices);
            Assert.IsTrue(houseLocalPrices.Length > 0);
        }

        [TestMethod]
        public async Task HouseOpenPrices()
        {
            var houseOpenPrices = await _guernseyDb.GetHouseOpenPrices();

            Assert.IsNotNull(houseOpenPrices);
            Assert.IsTrue(houseOpenPrices.Length > 0);
        }

        [TestMethod]
        public async Task HouseTypes()
        {
            var houseTypes = await _guernseyDb.GetHouseTypes();

            Assert.IsNotNull(houseTypes);
            Assert.IsTrue(houseTypes.Length > 0);
        }

        [TestMethod]
        public async Task HouseUnits()
        {
            var houseUnits = await _guernseyDb.GetHouseUnits();

            Assert.IsNotNull(houseUnits);
            Assert.IsTrue(houseUnits.Length > 0);
        }

        [TestMethod]
        public async Task InflationChanges()
        {
            var inflationChanges = await _guernseyDb.GetInflationChanges();

            Assert.IsNotNull(inflationChanges);
            Assert.IsTrue(inflationChanges.Length > 0);
        }

        [TestMethod]
        public async Task InflationRpixGroupChanges()
        {
            var inflationRpixGroupChanges = await _guernseyDb.GetInflationRpixGroupChanges();

            Assert.IsNotNull(inflationRpixGroupChanges);
            Assert.IsTrue(inflationRpixGroupChanges.Length > 0);
        }

        [TestMethod]
        public async Task InflationRpiGroupChanges()
        {
            var inflationRpiGroupChanges = await _guernseyDb.GetInflationRpiGroupChanges();

            Assert.IsNotNull(inflationRpiGroupChanges);
            Assert.IsTrue(inflationRpiGroupChanges.Length > 0);
        }

        [TestMethod]
        public async Task OverseasContributions()
        {
            var overseasContributions = await _guernseyDb.GetOverseasContributions();

            Assert.IsNotNull(overseasContributions);
            Assert.IsTrue(overseasContributions.Length > 0);
        }

        [TestMethod]
        public async Task PopulationAge()
        {
            var populationAge = await _guernseyDb.GetPopulationAge();

            Assert.IsNotNull(populationAge);
            Assert.IsTrue(populationAge.Length > 0);
        }

        [TestMethod]
        public async Task PopulationAgeFemale()
        {
            var populationAgeFemale = await _guernseyDb.GetPopulationAgeFemale();

            Assert.IsNotNull(populationAgeFemale);
            Assert.IsTrue(populationAgeFemale.Length > 0);
        }

        [TestMethod]
        public async Task PopulationAgeMale()
        {
            var populationAgeMale = await _guernseyDb.GetPopulationAgeMale();

            Assert.IsNotNull(populationAgeMale);
            Assert.IsTrue(populationAgeMale.Length > 0);
        }

        [TestMethod]
        public async Task PopulationBirthplace()
        {
            var populationBirthplace = await _guernseyDb.GetPopulationBirthplace();

            Assert.IsNotNull(populationBirthplace);
            Assert.IsTrue(populationBirthplace.Length > 0);
        }

        [TestMethod]
        public async Task GetPopulationChanges()
        {
            var popChanges = await _guernseyDb.GetPopulationChanges();

            Assert.IsNotNull(popChanges);
            Assert.IsTrue(popChanges.Length > 0);
        }

        [TestMethod]
        public async Task PopulationDistrict()
        {
            var populationDistrict = await _guernseyDb.GetPopulationDistrict();

            Assert.IsNotNull(populationDistrict);
            Assert.IsTrue(populationDistrict.Length > 0);
        }

        [TestMethod]
        public async Task PopulationParish()
        {
            var populationParish = await _guernseyDb.GetPopulationParish();

            Assert.IsNotNull(populationParish);
            Assert.IsTrue(populationParish.Length > 0);
        }

        [TestMethod]
        public async Task Population()
        {
            var population = await _guernseyDb.GetPopulation();

            Assert.IsNotNull(population);
            Assert.IsTrue(population.Length > 0);
        }

        [TestMethod]
        public async Task SailingsCondorPunctuality()
        {
            var sailingsCondorPunctuality = await _guernseyDb.GetSailingsCondorPunctuality();

            Assert.IsNotNull(sailingsCondorPunctuality);
            Assert.IsTrue(sailingsCondorPunctuality.Length > 0);
        }

        [TestMethod]
        public async Task SailingsCruises()
        {
            var sailingsCruises = await _guernseyDb.GetSailingsCruises();

            Assert.IsNotNull(sailingsCruises);
            Assert.IsTrue(sailingsCruises.Length > 0);
        }

        [TestMethod]
        public async Task TourismAirByMonth()
        {
            var tourismAirByMonth = await _guernseyDb.GetTourismAirByMonth();

            Assert.IsNotNull(tourismAirByMonth);
            Assert.IsTrue(tourismAirByMonth.Length > 0);
        }

        [TestMethod]
        public async Task GetTourismCruises()
        {
            var cruises = await _guernseyDb.GetTourismCruises();

            Assert.IsNotNull(cruises);
            Assert.IsTrue(cruises.Length > 0);
        }

        [TestMethod]
        public async Task TourismSeaByMonth()
        {
            var tourismSeaByMonth = await _guernseyDb.GetTourismSeaByMonth();

            Assert.IsNotNull(tourismSeaByMonth);
            Assert.IsTrue(tourismSeaByMonth.Length > 0);
        }

        [TestMethod]
        public async Task Traffic()
        {
            var traffic = await _guernseyDb.GetTraffic();

            Assert.IsNotNull(traffic);
            Assert.IsTrue(traffic.Length > 0);
        }

        [TestMethod]
        public async Task TrafficClassifications()
        {
            var trafficClassifications = await _guernseyDb.GetTrafficClassifications();

            Assert.IsNotNull(trafficClassifications);
            Assert.IsTrue(trafficClassifications.Length > 0);
        }

        [TestMethod]
        public async Task TrafficCollisions()
        {
            var trafficCollisions = await _guernseyDb.GetTrafficCollisions();

            Assert.IsNotNull(trafficCollisions);
            Assert.IsTrue(trafficCollisions.Length > 0);
        }

        [TestMethod]
        public async Task TrafficInjuries()
        {
            var trafficInjuries = await _guernseyDb.GetTrafficInjuries();

            Assert.IsNotNull(trafficInjuries);
            Assert.IsTrue(trafficInjuries.Length > 0);
        }

        [TestMethod]
        public async Task TransportRegisteredVehicles()
        {
            var transportRegisteredVehicles = await _guernseyDb.GetTransportRegisteredVehicles();

            Assert.IsNotNull(transportRegisteredVehicles);
            Assert.IsTrue(transportRegisteredVehicles.Length > 0);
        }

        [TestMethod]
        public async Task WasteCommercialAndIndustrialWaste()
        {
            var wasteCommercialAndIndustrialWaste = await _guernseyDb.GetWasteCommercialAndIndustrialWaste();

            Assert.IsNotNull(wasteCommercialAndIndustrialWaste);
            Assert.IsTrue(wasteCommercialAndIndustrialWaste.Length > 0);
        }

        [TestMethod]
        public async Task WasteConstructionAndDemolition()
        {
            var wasteConstructionAndDemolition = await _guernseyDb.GetWasteConstructionAndDemolition();

            Assert.IsNotNull(wasteConstructionAndDemolition);
            Assert.IsTrue(wasteConstructionAndDemolition.Length > 0);
        }

        [TestMethod]
        public async Task WasteHousehold()
        {
            var wasteHousehold = await _guernseyDb.GetWasteHousehold();

            Assert.IsNotNull(wasteHousehold);
            Assert.IsTrue(wasteHousehold.Length > 0);
        }

        [TestMethod]
        public async Task WaterDomesticConsumption()
        {
            var waterDomesticConsumption = await _guernseyDb.GetWaterDomesticConsumption();

            Assert.IsNotNull(waterDomesticConsumption);
            Assert.IsTrue(waterDomesticConsumption.Length > 0);
        }

        [TestMethod]
        public async Task WaterNitrateConcentration()
        {
            var waterNitrateConcentration = await _guernseyDb.GetWaterNitrateConcentration();

            Assert.IsNotNull(waterNitrateConcentration);
            Assert.IsTrue(waterNitrateConcentration.Length > 0);
        }

        [TestMethod]
        public async Task WaterPollutionIncidents()
        {
            var waterPollutionIncidents = await _guernseyDb.GetWaterPollutionIncidents();

            Assert.IsNotNull(waterPollutionIncidents);
            Assert.IsTrue(waterPollutionIncidents.Length > 0);
        }

        [TestMethod]
        public async Task WaterUnaccounted()
        {
            var waterUnaccounted = await _guernseyDb.GetWaterUnaccounted();

            Assert.IsNotNull(waterUnaccounted);
            Assert.IsTrue(waterUnaccounted.Length > 0);
        }

        [TestMethod]
        public async Task WaterConsumption()
        {
            var waterConsumption = await _guernseyDb.GetWaterConsumption();

            Assert.IsNotNull(waterConsumption);
            Assert.IsTrue(waterConsumption.Length > 0);
        }

        [TestMethod]
        public async Task WaterQualityCompliance()
        {
            var waterQualityCompliance = await _guernseyDb.GetWaterQualityCompliance();

            Assert.IsNotNull(waterQualityCompliance);
            Assert.IsTrue(waterQualityCompliance.Length > 0);
        }

        [TestMethod]
        public async Task WaterStorage()
        {
            var waterStorage = await _guernseyDb.GetWaterStorage();

            Assert.IsNotNull(waterStorage);
            Assert.IsTrue(waterStorage.Length > 0);
        }

        [TestMethod]
        public async Task WeatherFrostDays()
        {
            var weatherFrostDays = await _guernseyDb.GetWeatherFrostDays();

            Assert.IsNotNull(weatherFrostDays);
            Assert.IsTrue(weatherFrostDays.Length > 0);
        }

        [TestMethod]
        public async Task WeatherMetOfficeAnnual()
        {
            var weatherMetOfficeAnnual = await _guernseyDb.GetWeatherMetOfficeAnnual();

            Assert.IsNotNull(weatherMetOfficeAnnual);
            Assert.IsTrue(weatherMetOfficeAnnual.Length > 0);
        }

        [TestMethod]
        public async Task WeatherMetOfficeMonthly()
        {
            var weatherMetOfficeMonthly = await _guernseyDb.GetWeatherMetOfficeMonthly();

            Assert.IsNotNull(weatherMetOfficeMonthly);
            Assert.IsTrue(weatherMetOfficeMonthly.Length > 0);
        }
    }
}
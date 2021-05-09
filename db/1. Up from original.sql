-- Create a new table called '[Parish]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[Parish]', 'U') IS NOT NULL
DROP TABLE [dbo].[Parish]
GO
-- Create a new table called '[DataCategory]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[DataSet]', 'U') IS NOT NULL
DROP TABLE [dbo].[DataSet]
GO
-- Create a new table called '[DataCategory]' in schema '[dbo]'
-- Drop the table if it already exists
IF OBJECT_ID('[dbo].[DataCategory]', 'U') IS NOT NULL
DROP TABLE [dbo].[DataCategory]
GO


-- Create the table in the specified schema
CREATE TABLE [dbo].[Parish]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, -- Primary Key column
    [Name] NVARCHAR(50) NOT NULL,
);
GO

INSERT INTO dbo.Parish ([Name])
    VALUES
    ('Castel'),
    ('Forest'),
    ('St Andrew'),
    ('St Martin'),
    ('St Peter Port'),
    ('St Pierre du Bois'),
    ('St Sampson'),
    ('St Saviour'),
    ('Torteval'),
    ('Vale')


-- Create the table in the specified schema
CREATE TABLE [dbo].[DataCategory]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, -- Primary Key column
    [Name] VARCHAR(50) NOT NULL,
    [Image] VARCHAR(50) NOT NULL,
    [Desc] VARCHAR(100) NOT NULL,
    [Stub] VARCHAR(50) NOT NULL,
    [ComingSoon] BIT DEFAULT(0),
    [ShowOnSite] BIT DEFAULT(1)
);
GO

INSERT INTO dbo.DataCategory ([Name], [Stub], [Desc], [Image], [ComingSoon], [ShowOnSite])
VALUES
('Buses', 'buses', 'Monthly usage of buses since 2011', 'i-814-bus-2x', 0, 1),
('Crime', 'crime', 'Detailed crime data from published reports', 'i-828-shield-2x', 0, 1),
('Earnings', 'earnings', 'Earnings by age group, sector, and sex', 'i-826-money-1-2x', 0, 1),
('Education', 'education', 'Post-16 results, overall GCSE grades and GCSE grades by school', 'i-897-graduation-cap-2x', 0, 1),
('Emissions', 'emissions', 'Emissions from published reports', 'i-1022-factory-2x', 0, 1),
('Employment', 'employment', 'Employment data from published reports', 'i-780-building-2x', 0, 1),
('Energy', 'energy', 'Electricity, nuclear, oil, gas, etc.', 'i-965-lightning-bolt-2x', 0, 1),
('Finance', 'finance', 'Finance industry stats', 'i-827-money-2-2x', 0, 1),
('Fire & Rescue', 'fire_and_rescue', 'Things the Fire & Rescue department deal with', 'i-923-spray-can-2x', 0, 1),
('Health', 'health', 'Health data from Chest & Heart screenings and government', 'i-892-bandaid-2x', 0, 1),
('Housing', 'housing', 'Detailed quarterly house prices since 1981 to today', 'i-750-home-2x', 0, 1),
('Inflation', 'inflation', 'RPI & RPIX inflation data from 1949', 'i-754-scale-2x', 0, 1),
('Overseas Aid', 'overseas_aid', 'Aid and emergency relief sent overseas', 'i-950-ekg-2x', 0, 1),
('Population', 'population', 'Guernsey population data from published reports', 'i-895-user-group-2x', 0, 1),
('Sailings', 'sailings', 'Sailing details refreshed on the fly from the Guernsey Harbour', 'i-1094-sail-boat-2-2x', 0, 1),
('Tourism', 'tourism', 'Incoming visitors', 'i-881-globe-2x', 0, 1),
('Traffic', 'traffic', 'Traffic data from published reports', 'i-815-car-2x', 0, 1),
('Transport', 'transport', 'Vehicle usage', 'i-917-speedometer-2x', 0, 1),
('Water', 'water', 'Water data from published reports', 'i-934-measuring-cup-2x', 0, 1),
('Weather', 'weather', 'Weather from published reports', 'i-862-sun-cloud-2x', 0, 1),
('Flights', 'flights', 'Flight details refreshed on the fly from the Guernsey Airport', 'i-893-airplane-2x', 0, 1),
('Fuel', 'fuel', 'Coming soon', 'i-931-gas-pump-2x', 1, 1),
('Sports', 'sports', 'Coming soon', 'i-1090-ping-pong-paddle-2x', 1, 1),
('Broadband', 'broadband', 'Coming soon', 'i-937-wifi-signal-2x', 1, 1),
('Waste', 'waste', 'Waste and recycling', 'i-776-recycle-2x', 0, 1),
('Roadworks', 'roadworks', 'Coming soon', 'i-1032-route-2x', 1, 1),
('Fishing', 'fishing', 'Coming soon', 'i-1029-fish-2x', 1, 1),
('Government spending', 'government-spending', 'Government spending since 2014', 'i-798-filter-2x', 0, 0)



-- Create the table in the specified schema
CREATE TABLE [dbo].[DataSet]
(
    [Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, -- Primary Key column
    [DataCategoryId] INT NOT NULL FOREIGN KEY REFERENCES DataCategory(Id),
    [Name] VARCHAR(50) NOT NULL,
    [Desc] VARCHAR(100) NOT NULL,
    [Filename] VARCHAR(50) NOT NULL,
    [Stub] VARCHAR(50) NOT NULL,
    [Live] BIT NOT NULL,
    [Source] VARCHAR(256) NOT NULL,
);
GO

INSERT INTO dbo.DataSet ([DataCategoryId], [Name], [Stub], [Desc], [Filename], [Live], [Source])
VALUES 
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'buses'), 'Usage', 'usage', 'Bus usage by year and month from 2011', 'buses/bus_usage.json', 0, 'http://www.gov.gg/PublicTransport'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'crime'), 'Crimes', 'crimes', 'Crime by offence since 2005', 'crime/crime.json', 0, 'http://www.guernsey.police.uk/article/6078/Publications'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'crime'), 'Prison Population', 'prison_population', 'Number of people in the prison', 'crime/prison_population.json', 0, 'https://www.gov.gg/prison'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'crime'), 'Worried', 'worried', 'Percentage of people worried about crime from a survey', 'crime/worried.json', 0, 'http://www.guernsey.police.uk/article/6078/Publications'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'traffic'), 'Traffic', 'traffic', 'Traffic incidents by offence and year', 'traffic/traffic.json', 0, 'http://www.guernsey.police.uk/article/6078/Publications'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'traffic'), 'Collisions', 'collisions', 'Traffic collisions by year', 'traffic/traffic_collisions.json', 0, 'http://www.guernsey.police.uk/article/6078/Publications'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'traffic'), 'Injuries', 'injuries', 'Traffic injuries by type and extent of injury', 'traffic/traffic_injuries.json', 0, 'http://www.guernsey.police.uk/article/6078/Publications'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'traffic'), 'Classifications', 'classifications', 'Traffic injury classifications (fatal, serious, slight)', 'traffic/traffic_classifications.json', 0, 'http://www.guernsey.police.uk/article/6078/Publications'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'housing'), 'Local Prices', 'local_prices', 'House prices by quarter since 1981 includes numerous stats', 'houses/local_prices.json', 0, 'http://gov.gg/article/112353/Quarterly-Residential-Property-Prices-and-Annual-Housing-Stock-Bulletins-2014'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'housing'), 'Open Prices', 'open_prices', 'House prices by quarter since 1981 includes numerous stats', 'houses/open_prices.json', 0, 'http://gov.gg/article/112353/Quarterly-Residential-Property-Prices-and-Annual-Housing-Stock-Bulletins-2014'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'housing'), 'Bedrooms', 'bedrooms', 'Total bedrooms per unit with market since 2011', 'houses/bedrooms.json', 0, 'http://gov.gg/property'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'housing'), 'Types', 'types', 'Total units with market and type for 2014', 'houses/types.json', 0, 'http://gov.gg/property'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'housing'), 'Units', 'units', 'Total units by market since 2010', 'houses/units.json', 0, 'http://gov.gg/property'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'flights'), 'Arrivals', 'arrivals', 'Live arrival data from the Guernsey Airport', 'get_flights_arrivals', 1, 'https://www.airport.gg/arrivals-departures'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'flights'), 'Departures', 'departures', 'Live departure data from the Guernsey Airport', 'get_flights_departures', 1, 'https://www.airport.gg/arrivals-departures'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'sailings'), 'Harbour', 'harbour', 'Live sailings data from the Guernsey Harbour. Includes both arrivals and departures', 'get_harbour_sailings', 1, 'http://www.guernseyharbours.gov.gg/article/100192/Arrivals--Departures'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'sailings'), 'Condor Punctuality', 'condor_punctuality', 'Condor punctuality from published reports', 'sailings/condor_punctuality.json', 0, 'http://www.condorferries.co.uk/performance/punctuality-reports.aspx'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'sailings'), 'Cruises', 'cruises', 'Visiting cruise ships', 'sailings/cruises.json', 0, 'http://www.guernseyharbours.gov.gg/CHttpHandler.ashx?id=93382&p=0'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'education'), 'Post 16 Results', 'post16results', 'Post 16 results since 2010 by type, grade and percentage', 'education/post16results.json', 0, 'http://www.education.gg/'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'education'), 'GCSE Overall', 'gcse_overall', 'GCSE overall since 2009 by result and percentage', 'education/gcse_overall.json', 0, 'http://www.education.gg/'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'education'), 'GCSE School', 'gcse_school', 'GCSE results for schools since 2010 by result and percentage', 'education/gcse_school.json', 0, 'http://www.education.gg/'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'education'), 'Students in UK', 'students_in_uk', 'Students studying in the UK', 'education/students_in_uk.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'population'), 'Population', 'population', 'Population values by year, sex and age. Ages are in ranges.', 'population/population.json', 0, 'http://www.gov.gg/population'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'population'), 'Age', 'age', 'Population values by year and age. Individual year ages. Mixed sex.', 'population/age.json', 0, 'http://www.gov.gg/population'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'population'), 'Age Male', 'age_male', 'Population values by year and age. Individual year ages. Male only.', 'population/age_male.json', 0, 'http://www.gov.gg/population'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'population'), 'Age Female', 'age_female', 'Population values by year and age. Individual year ages. Female only.', 'population/age_female.json', 0, 'http://www.gov.gg/population'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'population'), 'Birthplace', 'birthplace', 'Population by birthplace.', 'population/birthplace.json', 0, 'http://www.gov.gg/population'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'population'), 'Changes', 'changes', 'Population changes by quarter. Has births, deaths, immigration and emigration.', 'population/changes.json', 0, 'http://www.gov.gg/population'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'population'), 'District', 'district', 'Population by voting district.', 'population/district.json', 0, 'http://www.gov.gg/population'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'population'), 'Parish', 'parish', 'Population by parish.', 'population/parish.json', 0, 'http://www.gov.gg/population'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'earnings'), 'Earnings Age Group', 'earnings_age_group', 'Earnings by age group since 2012, includes lower quartile, median and upper quartile.', 'earnings/earnings_age_group.json', 0, 'http://www.gov.gg/earnings'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'earnings'), 'Earnings Sector', 'earnings_sector', 'Earnings by sector since 2012, includes lower quartile, median and upper quartile.', 'earnings/earnings_sector.json', 0, 'http://www.gov.gg/earnings'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'earnings'), 'Earnings Sex', 'earnings_sex', 'Earnings by sex since 2005, includes nominal and real.', 'earnings/earnings_sex.json', 0, 'http://www.gov.gg/earnings'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'inflation'), 'Changes', 'changes', 'RPI & RPIX changes since 1949', 'inflation/changes.json', 0, 'http://www.gov.gg/rpi'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'inflation'), 'RPI Group Changes', 'rpi_group_changes', 'RPI group changes since Q4 2004', 'inflation/rpi_group_changes.json', 0, 'http://www.gov.gg/rpi'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'inflation'), 'RPIX Group Changes', 'rpix_group_changes', 'RPIX group changes since Q4 2014', 'inflation/rpix_group_changes.json', 0, 'http://www.gov.gg/rpi'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'water'), 'Domestic Consumption', 'domestic_consumption', 'Domestic water consumption since 2008 in ML', 'water/domestic_consumption.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'emissions'), 'Types', 'types', 'Emissions since 1990 by type in kt for Carbon Dioxide and kt of CO2 equivalent for others', 'emissions/type.json', 0, 'http://www.gov.gg/ghg'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'employment'), 'Totals', 'totals', 'Employed, unemployed and employer totals since Q4 2012 (missing Q4 2012 employed)', 'employment/totals.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'weather'), 'Annual', 'annual', 'Annual weather stats from 2010', 'weather/metoffice_annual_report.json', 0, 'http://www.metoffice.gov.gg/annualwxreports.html'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'weather'), 'Monthly', 'monthly', 'Monthly weather stats from Jan 2010', 'weather/metoffice_monthly_report.json', 0, 'http://www.metoffice.gov.gg/annualwxreports.html'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'weather'), 'Frost Days', 'frost_days', 'Frost days since 1946 (below 0°C)', 'weather/frost_days.json', 0, 'http://www.metoffice.gov.gg/annualwxreports.html'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'finance'), 'Banking', 'banking', 'Banking data', 'finance/banking.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'health'), 'Concerns', 'concerns', 'Concerns found during screenings', 'health/chest_and_heart_concerns.json', 0, 'http://www.chestandheart.org.gg/'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'health'), 'Totals', 'totals', 'Total numbers of screenings by age', 'health/chest_and_heart_totals.json', 0, 'http://www.chestandheart.org.gg/'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'health'), 'Medical Unit Bed Days Five Year Average', 'med_unit_bed_days_five_yr_avg', 'Medical Unit bed days five year average', 'health/med_unit_bed_days_five_yr_avg.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'fire_and_rescue'), 'Attendances', 'attendances', 'Attendances by Fire and Rescue services', 'fire_and_rescue/attendances.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'overseas_aid'), 'Contributions', 'contributions', 'Aid and emergency relief sent overseas', 'overseas_aid/contributions.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'tourism'), 'Cruises', 'cruises', 'Incoming cruise passengers', 'tourism/cruises.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'tourism'), 'Air by Month', 'air_by_month', 'Incoming air passengers by month', 'tourism/air_by_month.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'tourism'), 'Sea by Month', 'sea_by_month', 'Incoming sea passengers by month', 'tourism/sea_by_month.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'energy'), 'Electricity Consumption', 'electricity_consumption', 'Domestic and commercial electricity consumption', 'energy/electricity_consumption.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'energy'), 'Electricity Import vs Generated', 'electricity_import_vs_generated', 'Imported vs generated electricity', 'energy/electricity_import_vs_generated.json', 0, 'http://electricity.gg/'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'transport'), 'Registered Vehicles', 'registered_vehicles', 'Registered vehicles', 'transport/registered_vehicles.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'government-spending'), 'Breakdown', 'breakdown', 'Government spending breakdown from 2014', 'government_spending/breakdown.json', 0, 'https://www.gov.gg/data'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'emissions'), 'Source', 'source', 'Percentage contribution of emissions by source since 1990','emissions/source.json', 0, 'https://www.gov.gg/data'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'energy'), 'Gas', 'gas', 'Gas usage from 1990', 'energy/gas.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'energy'), 'Oil', 'oil', 'Oil imports since 2008', 'energy/oil_imports.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'energy'), 'Renewable', 'renewable', 'Renewable energy since 2008', 'energy/renewable_energy.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'waste'), 'Commercial and Industrial', 'commercial-and-industrial', 'Commercial and industrial waste since 2008', 'waste/commercial_and_industrial_waste.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'waste'), 'Construction and Demolition', 'construction-and-demolition', 'Construction and demolition waste since 2008', 'waste/construction_and_demolition_waste.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'waste'), 'Household', 'household', 'Household waste since 2008', 'waste/household_waste.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'water'), 'Nitrate Concentration', 'nitrate-concentration', 'Nitrate concentration since 2008', 'water/nitrate_concentration.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'water'), 'Pollution Incidents', 'pollution-incidents', 'Incidents of pollution since 2002', 'water/pollution_incidents.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'water'), 'Unaccounted Water', 'unaccounted-water', 'Water unaccounted for since 2011', 'water/unaccounted_water.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'water'), 'Water Consumption', 'water-consumption', 'Water consumption since 1998', 'water/water_consumption.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'water'), 'Water Quality Compliance', 'water-quality-compliance', 'Water quality compliance since 2002', 'water/water_quality_compliance.json', 0, 'http://www.gov.gg/pru'),
((SELECT TOP 1 Id FROM dbo.DataCategory WHERE [Stub] = 'water'), 'Water Storage', 'water-storage', 'Water storage since 2004', 'water/water_storage.json', 0, 'http://www.gov.gg/pru')


-- Create a new stored procedure called 'GetData' in schema 'dbo'
-- Drop the stored procedure if it already exists
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'GetData'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.GetData
GO
-- Create the stored procedure in the specified schema
CREATE PROCEDURE dbo.GetData
AS
BEGIN
    SELECT * FROM dbo.DataCategory

    SELECT * FROM dbo.DataSet
END
GO
-- example to execute the stored procedure we just created
EXECUTE dbo.GetData 
GO
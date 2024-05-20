// See https://aka.ms/new-console-template for more information

using System.Data;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using CsvHelper;
using CsvHelper.Configuration;

Console.WriteLine("Hello, World!");


using StreamReader reader = new StreamReader("rpix.csv");
using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)
{
    HasHeaderRecord = false
});

var records = new Dictionary<DateTime, Dictionary<string, InflationRow>>();

var periodCol = 0;
var typeCol = 1;

var startCol = 2;


using (var dr = new CsvDataReader(csv))
{
    var dt = new DataTable();
    dt.Load(dr);

    var columnCount = dt.Rows[0].ItemArray.Length;

    for (int i = 1; i < dt.Rows.Count; i++)
    {
        var row = dt.Rows[i];

        var timeframe = row[periodCol].ToString();
        var type = row[typeCol].ToString();

        for (int j = 2; j < columnCount; j++)
        {
            var period = dt.Rows[0][j].ToString();
            var periodAsDate = DateTime.Parse(period);

            if (!records.ContainsKey(periodAsDate))
            {
                records.Add(periodAsDate, new Dictionary<string, InflationRow>());
            }

            if (!records[periodAsDate].ContainsKey(type))
            {
                records[periodAsDate].Add(type, new InflationRow());
            }

            var qtr = periodAsDate.Month switch
                {
                    3 => 1,
                    6 => 2,
                    9 => 3,
                    12 => 4,
                    _ => throw new ArgumentException("wot")
                };

                
                records[periodAsDate][type].Quarter = $"Q{qtr} {periodAsDate:yyyy}";
                records[periodAsDate][type].Type = type;

                var valueAsStr = row[j].ToString();

                if (timeframe == "Quarterly")
                {
                    records[periodAsDate][type].QuarterlyChange =
                        !string.IsNullOrEmpty(valueAsStr) ? decimal.Parse(valueAsStr) : null;
                }
                else if (timeframe == "Annual")
                {
                    records[periodAsDate][type].AnnualChange = 
                        !string.IsNullOrEmpty(valueAsStr) ? decimal.Parse(valueAsStr) : null;
                }

            
        }
    }
}


var rows = new List<InflationRow>();
foreach (var innerDict in records.Values)
{
    rows.AddRange(innerDict.Values.Select(x => x));
}

var json = JsonSerializer.Serialize(rows);

Console.ReadLine();

public record InflationRow
{
    public string Type { get; set; }
    public string Quarter { get; set; }
    [JsonPropertyName("Quarterly Change")] public decimal? QuarterlyChange { get; set; }
    [JsonPropertyName("Annual Change")] public decimal? AnnualChange { get; set; }
}
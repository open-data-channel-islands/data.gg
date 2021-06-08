using DataGg.Core.Guernsey.Flights;
using HtmlAgilityPack;
using Serilog;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataGg.Core.Live
{
    public class AirportScraper
    {
        private const string Url = "https://www.airport.gg/arrivals-departures";
        private readonly HttpClient _client;

        public AirportScraper(HttpClient client)
        {
            _client = client;
        }

        public async Task<AirportScraperResult> Get()
        {
            var response = await _client.GetAsync(Url);

            if (!response.IsSuccessStatusCode)
            {
                Log.Error($"Airport Scrape httpStatus[{(int)response.StatusCode}] {response.StatusCode} for {Url} was not a successful one. Aborting scrape.");
                return null;
            }

            var content = await response.Content.ReadAsStringAsync();

            var html = new HtmlDocument();
            html.LoadHtml(content);

            var arrivals = GetArrivals(html);
            var departures = GetDepartures(html);

            return new AirportScraperResult
            {
                Arrivals = arrivals.ToArray(),
                Departures = departures.ToArray()
            };

        }

        private static List<Arrival> GetArrivals(HtmlDocument html)
        {
            var arrivals = new List<Arrival>();

            var arrivalsTable = html.DocumentNode.SelectSingleNode(".//table[@id='table-arrivals']");


            var rows = arrivalsTable.SelectNodes(".//tr");

            foreach (var r in rows)
            {
                var cells = r.SelectNodes(".//td");

                if (cells == null || cells.Count != 6)
                {
                    continue;
                }

                var time = cells[1].InnerText;
                var date = cells[2].SelectSingleNode(".//span[@class='date-large']").InnerText;


                var offsetParsed = DateTimeOffset.ParseExact($"{date} {time}",
                    "dd/MM/yyyy HH:mm", CultureInfo.CreateSpecificCulture("en-GB"));

                var dir = cells[3].InnerText;
                var flightNo = cells[4].InnerText;
                var status = cells[5].InnerText;

                arrivals.Add(new Arrival()
                {
                    Time = offsetParsed,
                    Source = dir,
                    FlightNumber = flightNo,
                    Status = status,
                });
            }

            return arrivals;
        }

        private static List<Departure> GetDepartures(HtmlDocument html)
        {
            var departures = new List<Departure>();

            var departuresTable = html.DocumentNode.SelectSingleNode(".//table[@id='table-departures']");


            var rows = departuresTable.SelectNodes(".//tr");

            foreach (var r in rows)
            {
                var cells = r.SelectNodes(".//td");

                if (cells == null || cells.Count != 6)
                {
                    continue;
                }

                var time = cells[1].InnerText;
                var date = cells[2].SelectSingleNode(".//span[@class='date-large']").InnerText;

                var offsetParsed = DateTimeOffset.ParseExact($"{date} {time}",
                    "dd/MM/yyyy HH:mm", CultureInfo.CreateSpecificCulture("en-GB"));


                var dir = cells[3].InnerText;
                var flightNo = cells[4].InnerText;
                var status = cells[5].InnerText;

                departures.Add(new Departure()
                {
                    Time = offsetParsed,
                    Dest = dir,
                    FlightNumber = flightNo,
                    Status = status,
                });
            }

            return departures;
        }






        public class AirportScraperResult
        {
            public Arrival[] Arrivals { get; set; }
            public Departure[] Departures { get; set; }
        }
    }
}

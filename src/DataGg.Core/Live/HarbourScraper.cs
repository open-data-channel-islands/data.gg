using DataGg.Core.Guernsey.Sailings;
using HtmlAgilityPack;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataGg.Core.Live
{
    public class HarbourScraper
    {
        private const string ArrivalUrl = "https://boards.gov.gg/webservices/harbours.asmx/GetTodaysArrivals?";
        private const string ArrivalTomUrl = "https://boards.gov.gg/webservices/harbours.asmx/GetTomorrowsArrivals?";
        private const string DepartureUrl = "https://boards.gov.gg/webservices/harbours.asmx/GetTodaysDepartures?";
        private const string DepartureTomUrl = "https://boards.gov.gg/webservices/harbours.asmx/GetTomorrowsDepartures?";

        private readonly HttpClient _client;

        public HarbourScraper(HttpClient client)
        {
            _client = client;
        }

        public async Task<Harbour[]> Get()
        {
            var arrivals1 = GetUrlArrivals(ArrivalUrl);
            var arrivals2 = GetUrlArrivals(ArrivalTomUrl);


            var departures1 = GetUrlDepartures(DepartureUrl);
            var departures2 = GetUrlDepartures(DepartureTomUrl);


            var arrivals = (await arrivals1).Union(await arrivals2).ToArray();
            var departures = (await departures1).Union(await departures2).ToArray();

            return departures.Union(arrivals).ToArray();

        }

        public async Task<string> GetString(string url)
        {
            //_client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var response = await _client.PostAsync(url, new StringContent(string.Empty, Encoding.ASCII, "application/xml"));

            if (!response.IsSuccessStatusCode)
            {
                Log.Error($"Harhbour Scrape httpStatus[{(int)response.StatusCode}] {response.StatusCode} for {url} was not a successful one. Aborting scrape.");
                return null;
            }

            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<Harbour[]> GetUrlArrivals(string url)
        {

            var content = await GetString(url);

            var html = new HtmlDocument();
            html.LoadHtml(content);

            var items = html.DocumentNode.SelectNodes("/arrayofportcall/portcall");

            if (items == null)
            {
                return new Harbour[0];
            }

            var arrivals = new List<Harbour>();
            foreach (var item in items)
            {

                var vessel = item.SelectSingleNode("./vesselname").InnerText;
                var time = item.SelectSingleNode("./eta_original").InnerText;
                var timeParsed = DateTimeOffset.Parse(time);

                var source = item.SelectSingleNode("./from").InnerText;
                var arrived = item.SelectSingleNode("./ata").InnerText;
                var arrivedParsed = (DateTimeOffset?)(!string.IsNullOrEmpty(arrived) ? DateTimeOffset.Parse(arrived) : null);

                arrivals.Add(new Harbour
                {
                    Vessel = vessel,
                    Time = timeParsed,
                    Source = source,
                    Type = "Arrival",
                    Arrived = arrivedParsed?.ToString("HH:mmA")
                }); ;
            }

            return arrivals.ToArray();
        }

        public async Task<Harbour[]> GetUrlDepartures(string url)
        {

            var content = await GetString(url);

            var html = new HtmlDocument();
            html.LoadHtml(content);

            var items = html.DocumentNode.SelectNodes("/arrayofportcall/portcall");
            if (items == null)
            {
                return new Harbour[0];
            }

            var departures = new List<Harbour>();
            foreach (var item in items)
            {

                var vessel = item.SelectSingleNode("./vesselname").InnerText;
                var time = item.SelectSingleNode("./etd_original").InnerText;
                var timeParsed = DateTimeOffset.Parse(time);

                var source = item.SelectSingleNode("./to").InnerText;
                var departed = item.SelectSingleNode("./atd").InnerText;
                var departedParsed = (DateTimeOffset?)(!string.IsNullOrEmpty(departed) ? DateTimeOffset.Parse(departed) : null);

                departures.Add(new Harbour
                {
                    Vessel = vessel,
                    Time = timeParsed,
                    Destination = source,
                    Type = "Departure",
                    Departed = departedParsed?.ToString("HH:mmA")
                });
            }

            return departures.ToArray();
        }
    }

}

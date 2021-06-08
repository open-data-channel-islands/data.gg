using DataGg.Core.Live;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataGg.Test
{
    [TestClass]
    public class LiveDataTests
    {

        [TestMethod]
        public async Task Flights()
        {
            var scraper = new AirportScraper(new HttpClient());
            var res = await scraper.Get();

            Assert.IsTrue(res.Arrivals.Length > 1);
            Assert.IsTrue(res.Departures.Length > 1);
        }

        [TestMethod]
        public async Task Harbour()
        {
            var scraper = new HarbourScraper(new HttpClient());
            var res = await scraper.Get();

            Assert.IsTrue(res.Length > 1);
        }


    }
}

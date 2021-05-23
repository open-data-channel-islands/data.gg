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

            await scraper.Get();
        }

    }
}

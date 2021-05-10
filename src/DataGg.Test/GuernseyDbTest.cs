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
            Assert.IsNotNull(busUsage.Length > 0);
        }
    }
}

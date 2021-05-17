using DataGg.Core.Guernsey.Buses;
using DataGg.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGg.Web.Controllers
{
    [Route("api")]
    [Route("api/1.1")]
    [Route("api/1.0")]

    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly CacheManager _cacheManager;
        
        public DataController(CacheManager cacheManager)
        {

            _cacheManager = cacheManager;
        }

        [HttpGet]
        [Route("buses/usage")]
        [Route("buses/usage.json")]
        public async Task<IEnumerable<BusUsage>> BusUsage()
        {
            var dataCache = await _cacheManager.DataCache.Get();

            return dataCache.BusUsage;
        }
    }
}

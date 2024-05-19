using DataGg.Core.Guernsey.Buses;
using DataGg.Core.Live;
using DataGg.Core.Types;
using DataGg.Database;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DataGg.Web.Services
{
    public class CacheManager
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<CacheManager> _logger;
        private readonly RootDb _rootDb;
        private readonly GuernseyDb _guernseyDb;

        public bool CacheRebuildRequested { get; private set; } = false;

        public CachableThing<DataCategoryDto[]> DataCategories { get; init; }
        public CachableThing<DataCache> DataCache { get; init; }
        private CachableThing<LiveDataCache> LiveDataCache { get; init; }

     
        public CacheManager(IMemoryCache cache, ILogger<CacheManager> logger, RootDb rootDb, GuernseyDb guernseyDb)
        {
            _memoryCache = cache;
            _logger = logger;
            _rootDb = rootDb;
            _guernseyDb = guernseyDb;   

            DataCategories = new CachableThing<DataCategoryDto[]>(nameof(DataCategories), _memoryCache, _rootDb.GetData);
            DataCache = new CachableThing<DataCache>(nameof(DataCache), _memoryCache, _guernseyDb.GetDataCache);

            LiveDataCache = new CachableThing<LiveDataCache>(nameof(LiveDataCache), _memoryCache,
                async() =>
                {
                    // TODO: Figure out good way to use the injected client
                    using var client = new HttpClient();

                    var airportScraper = new AirportScraper(client);
                    var airportScraperTask = airportScraper.Get();

                    var harbourScraper = new HarbourScraper(client);
                    var harbourScraperTask = harbourScraper.Get();

                    var airportLatest = await airportScraperTask;
                    var harbourLatest = await harbourScraperTask;

                    return new LiveDataCache
                    {
                        AirportArrivals = airportLatest.Arrivals,
                        AirportDepartures = airportLatest.Departures,
                        Harbour = harbourLatest,
 
                    };
                });
        }

        public async Task<LiveDataCache> GetLiveDataCache()
        {
            while (LiveDataCache.CacheInProgress)
            {
                await Task.Delay(TimeSpan.FromSeconds(1));
            }

            var now = DateTime.UtcNow;

            if (LiveDataCache.LastCache.AddMinutes(1) < now)
            {
                await LiveDataCache.DoCache();
            }

            return await LiveDataCache.Get();
        }

        public async Task DoCache()
        {
            await CacheThings();
            CacheRebuildRequested = false;
        }

        internal void ExecuteAsyncStopped()
        {
            _logger.LogError("Cache Critical Error: ExecuteAsyncStopped");
        }

        public async Task CacheThings()
        {
            //await _rootDb.InsertAllDataJson();

            try
            {
                await DataCategories.DoCache();
                await DataCache.DoCache();
                await LiveDataCache.DoCache();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Cache Critical Error: CacheThings");
            }

        }

        public void RequestCacheRebuild()
        {
            CacheRebuildRequested = true;
        }
    }

    public class CachableThing<T> where T : class
    {
        public CachableThing(string cacheKey, IMemoryCache memoryCache, Func<Task<T>> getter)
        {
            _cacheKey = cacheKey;
            _memoryCache = memoryCache;
            _getter = getter;
        }

        public event Action Refreshed;

        private readonly string _cacheKey;
        private readonly IMemoryCache _memoryCache;
        private readonly Func<Task<T>> _getter;

        public DateTime LastCache { get; private set; } = DateTime.UtcNow;
        public bool CacheInProgress { get; private set; } = false;
        public bool IsCached => _memoryCache.TryGetValue(_cacheKey, out T items);
        public string Name { get { return _cacheKey; } }

        public async Task<T> Get()
        {

            T items;

            if (!_memoryCache.TryGetValue(_cacheKey, out items) && !CacheInProgress)
            {
                await DoCache();
            }

            while (!_memoryCache.TryGetValue(_cacheKey, out items))
            {
                await Task.Delay(100);
            }

            return items;
        }

        public async Task DoCache()
        {
            CacheInProgress = true;
            try
            {

                var dataToCache = await _getter.Invoke();
                _memoryCache.Set(_cacheKey, dataToCache);
                LastCache = DateTime.UtcNow;
            }
            finally
            {
                CacheInProgress = false;        
                Refreshed?.Invoke();
            }

        }
    }
}

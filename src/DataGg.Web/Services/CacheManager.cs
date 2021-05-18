﻿using DataGg.Core.Guernsey.Buses;
using DataGg.Core.Types;
using DataGg.Database;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public CachableThing<DataCategoryDto[]> DataCategories { get; set; }
        public CachableThing<DataCache> DataCache { get; set; }

        public CacheManager(IMemoryCache cache, ILogger<CacheManager> logger, RootDb rootDb, GuernseyDb guernseyDb)
        {
            _memoryCache = cache;
            _logger = logger;
            _rootDb = rootDb;
            _guernseyDb = guernseyDb;   

            DataCategories = new CachableThing<DataCategoryDto[]>(nameof(DataCategories), _memoryCache, _rootDb.GetData);
            DataCache = new CachableThing<DataCache>(nameof(DataCache), _memoryCache, _guernseyDb.GetDataCache);
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

        public DateTime LastCache { get; private set; } = DateTime.Now;
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
                LastCache = DateTime.Now;
            }
            finally
            {
                CacheInProgress = false;        
                Refreshed?.Invoke();
            }

        }
    }
}

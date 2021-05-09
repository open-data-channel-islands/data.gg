using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DataGg.Web.Services
{
    public class CacheBackgroundService : BackgroundService
    {
        protected readonly CacheManager CacheManager;
        protected int RefreshHours = 0;
        private bool _hasDoneFirstCache = false;

        // default to past 
        private DateTime _lastCache = DateTime.Today.AddDays(-1);

        public CacheBackgroundService(CacheManager cacheManager)
        {
            CacheManager = cacheManager;
 
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            while (!stoppingToken.IsCancellationRequested) { 
            
                if (ShouldStartTask())
                {
                    await CacheAll();
                }
                else if (CacheManager.CacheRebuildRequested)
                {
                    await CacheAll();
                }
               
                await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
            }

            CacheManager.ExecuteAsyncStopped();
        }

        private bool ShouldStartTask()
        {
            if (_hasDoneFirstCache && RefreshHours == 0)
            {
                return false;
            }

            DateTime currentTime = DateTime.Now;
            var timePassed = currentTime - _lastCache;

            if (timePassed.TotalHours >= RefreshHours)
            {
                _lastCache = currentTime;
                return true;
            }

            return false;
        }

        private async Task CacheAll()
        {
            await CacheManager.DoCache();
            _hasDoneFirstCache = true;
        }
    }
}

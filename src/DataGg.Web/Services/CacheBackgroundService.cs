using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DataGg.Web.Services
{
    public class CacheBackgroundService : BackgroundService
    {
        private readonly CacheManager _cacheManager;
        private int RefreshHours = 0;
        private bool _hasDoneFirstCache = false;

        // default to past 
        private DateTime _lastCache = DateTime.Today.AddDays(-1);

        public CacheBackgroundService(CacheManager cacheManager)
        {
            _cacheManager = cacheManager;
 
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {

            while (!stoppingToken.IsCancellationRequested) { 
            
                if (ShouldStartTask())
                {
                    await CacheAll();
                }
                else if (_cacheManager.CacheRebuildRequested)
                {
                    await CacheAll();
                }
               
                await Task.Delay(TimeSpan.FromHours(1), stoppingToken);
            }

            _cacheManager.ExecuteAsyncStopped();
        }

        private bool ShouldStartTask()
        {
            if (_hasDoneFirstCache && RefreshHours == 0)
            {
                return false;
            }

            DateTime currentTime = DateTime.UtcNow;
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
            await _cacheManager.DoCache();
            _hasDoneFirstCache = true;
        }
    }
}

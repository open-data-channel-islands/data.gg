using DataGg.Core.Types;
using DataGg.Web.Services;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DataGg.Web.ViewComponents
{
    public class FrontChartViewComponent : ViewComponent
    {

        private readonly CacheManager _cacheManager;

        public FrontChartViewComponent(CacheManager cacheManager)
        {

            _cacheManager = cacheManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var dataCache = await _cacheManager.DataCache.Get();

            var model = new FrontChartViewComponentModel();

            var culture = CultureInfo.GetCultureInfo("en-GB");

            // there are words here saying why its 13 and not 12
            // https://docs.microsoft.com/en-us/dotnet/api/system.globalization.datetimeformatinfo.abbreviatedmonthnames?view=net-5.0
            // it's rubbish, but there are words
            var monthNames = culture.DateTimeFormat.AbbreviatedMonthNames.Take(12);

            model.BusUsage = new List<AreaSeriesData>();
            model.BusUsageLabels = new List<string>();

            foreach(var year in dataCache.BusUsage.OrderBy(y=>y.Year))
            {
                foreach(var m in monthNames)
                {
                    model.BusUsageLabels.Add($"{m} {year.Year}");
                }

                model.BusUsage.Add(new AreaSeriesData { Y = year.January });
                model.BusUsage.Add(new AreaSeriesData { Y = year.February });
                model.BusUsage.Add(new AreaSeriesData { Y = year.March});
                model.BusUsage.Add(new AreaSeriesData { Y = year.April });
                model.BusUsage.Add(new AreaSeriesData { Y = year.May });
                model.BusUsage.Add(new AreaSeriesData { Y = year.June });
                model.BusUsage.Add(new AreaSeriesData { Y = year.July });
                model.BusUsage.Add(new AreaSeriesData { Y = year.August });
                model.BusUsage.Add(new AreaSeriesData { Y = year.September });
                model.BusUsage.Add(new AreaSeriesData { Y = year.October });
                model.BusUsage.Add(new AreaSeriesData { Y = year.November });
                model.BusUsage.Add(new AreaSeriesData { Y = year.December });
            }

            return View(model);
        }
    }

    public class FrontChartViewComponentModel
    {
        public List<AreaSeriesData> BusUsage { get; set; }
        public List<string> BusUsageLabels { get; set; }
    }
}

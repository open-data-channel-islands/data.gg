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
    public class PrisonPopulationChartViewComponent : ViewComponent
    {

        private readonly CacheManager _cacheManager;

        public PrisonPopulationChartViewComponent(CacheManager cacheManager)
        {

            _cacheManager = cacheManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var dataCache = await _cacheManager.DataCache.Get();

            var model = new PrisonPopulationChartViewComponentModel();

            var culture = CultureInfo.GetCultureInfo("en-GB");


            model.PrisonPopulation = new List<AreaSeriesData>();
            model.PrisonPopulationLabels = new List<string>();

            foreach (var point in dataCache.CrimePrisonPopulation.OrderBy(y => y.Year))
            {
                model.PrisonPopulationLabels.Add($"{point.Year}");
                model.PrisonPopulation.Add(new AreaSeriesData { Y = point.NumberOfPrisoners });
            }

            return View(model);
        }
    }

    public class PrisonPopulationChartViewComponentModel
    {
        public List<AreaSeriesData> PrisonPopulation { get; set; }
        public List<string> PrisonPopulationLabels { get; set; }
    }
}

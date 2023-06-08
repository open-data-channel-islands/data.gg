using DataGg.Core.Types;
using DataGg.Web.Models;
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
    public class WasteHouseholdChartViewComponent : ViewComponent
    {

        private readonly CacheManager _cacheManager;

        public WasteHouseholdChartViewComponent(CacheManager cacheManager)
        {

            _cacheManager = cacheManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var dataCache = await _cacheManager.DataCache.Get();

            var model = new LineChartViewModel() { TitleText = "Household", YAxisTitleText = "Household", Id = "chartHousehold" };

            var landfillSet = new List<LineSeriesData>();
            var recoverySet = new List<LineSeriesData>();
            var recycledSet = new List<LineSeriesData>();
            var compostedSet = new List<LineSeriesData>();
            


            model.Data = new List<Series>
            {
                new LineSeries { Name = "Landfill", Data = landfillSet },
                new LineSeries { Name = "Recovery", Data = recoverySet },
                new LineSeries { Name = "Recycled", Data = recycledSet },
                new LineSeries { Name = "Composted", Data = compostedSet },

            };
            
            model.Labels = new List<string>();

            foreach (var qtr in dataCache.WasteHousehold.OrderBy(y => y.Year))
            {
                landfillSet.Add(new LineSeriesData { Y = qtr.Landfill });
                recoverySet.Add(new LineSeriesData { Y = qtr.Recovery });
                recycledSet.Add(new LineSeriesData { Y = qtr.Recycled });
                compostedSet.Add(new LineSeriesData { Y = qtr.Composted });

                
                model.Labels.Add($"{qtr.Year}");

            }

            return View(model);
        }
    }
}

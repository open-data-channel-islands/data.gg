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
    public class EmploymentTotalsChartViewComponent : ViewComponent
    {

        private readonly CacheManager _cacheManager;

        public EmploymentTotalsChartViewComponent(CacheManager cacheManager)
        {

            _cacheManager = cacheManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var dataCache = await _cacheManager.DataCache.Get();

            var model = new LineChartViewModel() { TitleText = "Totals", YAxisTitleText = "Totals", Id = "chartTotals" };

            var employedSet = new List<LineSeriesData>();
            var selfEmployedSet = new List<LineSeriesData>();
            var unemployedSet = new List<LineSeriesData>();
                


            model.Data = new List<Series>
            {
                new LineSeries { Name = "Employed", Data = employedSet },
                new LineSeries { Name = "Self-employed", Data = selfEmployedSet },
                new LineSeries { Name = "Registered Unemployed", Data = unemployedSet },

            };
            
            model.Labels = new List<string>();

            foreach (var qtr in dataCache.EmploymentTotals.OrderBy(y => DateTime.Parse(y.DateTaken)))
            {
                employedSet.Add(new LineSeriesData { Y = qtr.TotalInEmployment });
                selfEmployedSet.Add(new LineSeriesData { Y = qtr.TotalSelfEmployees });
                unemployedSet.Add(new LineSeriesData() { Y = qtr.TotalRegisteredUnemployed});
                model.Labels.Add($"{qtr.DateTaken}");

            }

            return View(model);
        }
    }
}

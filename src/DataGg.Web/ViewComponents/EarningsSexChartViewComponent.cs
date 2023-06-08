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
    public class EarningsSexChartViewComponent : ViewComponent
    {

        private readonly CacheManager _cacheManager;

        public EarningsSexChartViewComponent(CacheManager cacheManager)
        {

            _cacheManager = cacheManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var dataCache = await _cacheManager.DataCache.Get();

            var model = new LineChartViewModel() { TitleText = "Sex", YAxisTitleText = "Sex", Id = "chartSex" };

            var maleSet = new List<LineSeriesData>();
            var femaleSet = new List<LineSeriesData>();


            model.Data = new List<Series>
            {
                new LineSeries { Name = "Male", Data = maleSet },
                new LineSeries { Name = "Female", Data = femaleSet },

            };
            
            model.Labels = new List<string>();

            foreach (var qtr in dataCache.EarningsSex.OrderBy(y => DateTime.Parse(y.Date)))
            {
                maleSet.Add(new LineSeriesData { Y = qtr.Male });
                femaleSet.Add(new LineSeriesData { Y = qtr.Female });

                
                model.Labels.Add($"{qtr.Date}");

            }

            return View(model);
        }
    }
}

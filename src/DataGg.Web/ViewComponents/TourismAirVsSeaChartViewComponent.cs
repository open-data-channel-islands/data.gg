using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Web.Models;
using DataGg.Web.Services;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc;

namespace DataGg.Web.ViewComponents;

public class TourismAirVsSeaChartViewComponent : ViewComponent
{
    private readonly CacheManager _cacheManager;

    public TourismAirVsSeaChartViewComponent(CacheManager cacheManager)
    {
        _cacheManager = cacheManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var dataCache = await _cacheManager.DataCache.Get();

        var model = new LineChartViewModel
            { TitleText = "Tourism Air vs Sea", YAxisTitleText = "Count", Id = "chartAirVsSea" };

        var air = new List<LineSeriesData>();
        var sea = new List<LineSeriesData>();


        model.Data = new List<Series>
        {
            new LineSeries { Name = "Air", Data = air },
            new LineSeries { Name = "Sea", Data = sea }
        };

        model.Labels = new List<string>();


        foreach (var qtr in dataCache.TourismAirByMonth.OrderBy(y => y.Year))
        {
            var airForYear = qtr;
            var seaForYear = dataCache.TourismSeaByMonth.First(x => x.Year == qtr.Year);


            air.AddRange([
                new LineSeriesData { Y = airForYear.January },
                new LineSeriesData { Y = airForYear.February },
                new LineSeriesData { Y = airForYear.March }, 
                new LineSeriesData { Y = airForYear.April },
                new LineSeriesData { Y = airForYear.May },
                new LineSeriesData { Y = airForYear.June },
                new LineSeriesData { Y = airForYear.July },
                new LineSeriesData { Y = airForYear.August },
                new LineSeriesData { Y = airForYear.September },
                new LineSeriesData { Y = airForYear.October },
                new LineSeriesData { Y = airForYear.November },
                new LineSeriesData { Y = airForYear.December }
            ]);

            sea.AddRange([
                new LineSeriesData { Y = seaForYear.January },
                new LineSeriesData { Y = seaForYear.February },
                new LineSeriesData { Y = seaForYear.March }, 
                new LineSeriesData { Y = seaForYear.April },
                new LineSeriesData { Y = seaForYear.May },
                new LineSeriesData { Y = seaForYear.June },
                new LineSeriesData { Y = seaForYear.July },
                new LineSeriesData { Y = seaForYear.August },
                new LineSeriesData { Y = seaForYear.September },
                new LineSeriesData { Y = seaForYear.October },
                new LineSeriesData { Y = seaForYear.November },
                new LineSeriesData { Y = seaForYear.December }
            ]);


            model.Labels.AddRange([
                $"{qtr.Year} Jan",
                $"{qtr.Year} Feb",
                $"{qtr.Year} Mar", 
                $"{qtr.Year} Apr",
                $"{qtr.Year} May",
                $"{qtr.Year} Jun",
                $"{qtr.Year} Jul",
                $"{qtr.Year} Aug",
                $"{qtr.Year} Sep",
                $"{qtr.Year} Oct",
                $"{qtr.Year} Nov",
                $"{qtr.Year} Dec"
            ]);
        }

        return View(model);
    }
}
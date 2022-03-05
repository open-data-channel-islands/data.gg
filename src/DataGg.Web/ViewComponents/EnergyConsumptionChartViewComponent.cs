using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Web.Models;
using DataGg.Web.Services;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc;

namespace DataGg.Web.ViewComponents;

public class EnergyConsumptionChartViewComponent : ViewComponent
{
    private readonly CacheManager _cacheManager;

    public EnergyConsumptionChartViewComponent(CacheManager cacheManager)
    {
        _cacheManager = cacheManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var dataCache = await _cacheManager.DataCache.Get();

        var model = new LineChartViewModel { TitleText = "Consumption", YAxisTitleText = "Number of Units (GWh)", Id = "chartConsumption" };

        var domestic = new List<LineSeriesData>();
        var commercial = new List<LineSeriesData>();


        model.Data = new List<Series>
        {
            new LineSeries { Name = "Domestic", Data = domestic },
            new LineSeries { Name = "Commercial", Data = commercial },

        };
        model.Labels = new List<string>();

        foreach (var qtr in dataCache.EnergyElectricityConsumption.OrderBy(y => y.Year))
        {
            domestic.Add(new LineSeriesData
            {
                Y = qtr.Domestic
            });

            commercial.Add(new LineSeriesData
            {
                Y = qtr.Commercial
            });


            model.Labels.Add($"{qtr.Year}");
        }

        return View(model);
    }
}
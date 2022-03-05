using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Web.Models;
using DataGg.Web.Services;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc;

namespace DataGg.Web.ViewComponents;

public class EnergyRenewableChartViewComponent : ViewComponent
{
    private readonly CacheManager _cacheManager;

    public EnergyRenewableChartViewComponent(CacheManager cacheManager)
    {
        _cacheManager = cacheManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var dataCache = await _cacheManager.DataCache.Get();

        var model = new LineChartViewModel { TitleText = "Renewable", YAxisTitleText = "%", Id = "chartRenewable" };

        var renewable = new List<LineSeriesData>();



        model.Data = new List<Series>
        {
            new LineSeries { Name = "Renewable", Data = renewable },

        };
        model.Labels = new List<string>();

        foreach (var qtr in dataCache.EnergyRenewable.OrderBy(y => y.Year))
        {
            renewable.Add(new LineSeriesData
            {
                Y = qtr.PercentageOfTotal
            });
            
            model.Labels.Add($"{qtr.Year}");
        }

        return View(model);
    }
}
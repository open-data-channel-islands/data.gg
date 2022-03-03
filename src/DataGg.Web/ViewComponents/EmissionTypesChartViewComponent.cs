using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Web.Models;
using DataGg.Web.Services;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc;

namespace DataGg.Web.ViewComponents;

public class EmissionTypesChartViewComponent : ViewComponent
{
    private readonly CacheManager _cacheManager;

    public EmissionTypesChartViewComponent(CacheManager cacheManager)
    {
        _cacheManager = cacheManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var dataCache = await _cacheManager.DataCache.Get();

        var model = new LineChartViewModel { TitleText = "Types", YAxisTitleText = "Types", Id = "chartTypes" };

        var ch4TotalMethane = new List<LineSeriesData>();
        var fluorinatedGasesTotal = new List<LineSeriesData>();
        var co2CarbonDioxideTotal = new List<LineSeriesData>();
        var n2OTotalNitrousOxide = new List<LineSeriesData>();

        model.Data = new List<Series>
        {
            new LineSeries { Name = "CH4 Total Methane", Data = ch4TotalMethane },
            new LineSeries { Name = "Fluorinated Gases Total", Data = fluorinatedGasesTotal },
            new LineSeries { Name = "O2 Carbon Dioxide Total", Data = co2CarbonDioxideTotal },
            new LineSeries { Name = "N2O Nitrous Oxide Total", Data = n2OTotalNitrousOxide }
        };
        model.Labels = new List<string>();

        foreach (var qtr in dataCache.EmissionType.OrderBy(y => y.Year))
        {
            ch4TotalMethane.Add(new LineSeriesData
            {
                Y = qtr.Ch4TotalMethane
            });

            fluorinatedGasesTotal.Add(new LineSeriesData
            {
                Y = qtr.FluorinatedGasesTotal
            });

            co2CarbonDioxideTotal.Add(new LineSeriesData
            {
                Y = qtr.Co2CarbonDioxideTotal
            });

            n2OTotalNitrousOxide.Add(new LineSeriesData
            {
                Y = qtr.N2OTotalNitrousOxide
            });

            model.Labels.Add($"{qtr.Year}");
        }

        return View(model);
    }
}
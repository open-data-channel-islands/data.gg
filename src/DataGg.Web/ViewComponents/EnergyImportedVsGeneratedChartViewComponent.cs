using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Web.Models;
using DataGg.Web.Services;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc;

namespace DataGg.Web.ViewComponents;

public class EnergyImportedVsGeneratedChartViewComponent : ViewComponent
{
    private readonly CacheManager _cacheManager;

    public EnergyImportedVsGeneratedChartViewComponent(CacheManager cacheManager)
    {
        _cacheManager = cacheManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var dataCache = await _cacheManager.DataCache.Get();

        var model = new LineChartViewModel { TitleText = "Imported vs Generated", YAxisTitleText = "MWh", Id = "chartImportedVsGenerated" };

        var imported = new List<LineSeriesData>();
        var generated = new List<LineSeriesData>();


        model.Data = new List<Series>
        {
            new LineSeries { Name = "Imported", Data = imported },
            new LineSeries { Name = "Generated", Data = generated },

        };
        model.Labels = new List<string>();

        foreach (var qtr in dataCache.EnergyElectricityImportVsGenerated.OrderBy(y => y.Year))
        {
            imported.Add(new LineSeriesData
            {
                Y = qtr.ElectricityImportedMWh
            });

            generated.Add(new LineSeriesData
            {
                Y = qtr.ElectricityGeneratedMWh
            });


            model.Labels.Add($"{qtr.Year}");
        }

        return View(model);
    }
}
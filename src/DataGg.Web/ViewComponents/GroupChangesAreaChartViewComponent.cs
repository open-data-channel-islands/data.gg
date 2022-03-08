using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Core.Guernsey.Inflation;
using DataGg.Web.Models;
using DataGg.Web.Services;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc;

namespace DataGg.Web.ViewComponents;

public class GroupChangesAreaChartViewComponent : ViewComponent
{
    private readonly CacheManager _cacheManager;

    public GroupChangesAreaChartViewComponent(CacheManager cacheManager)
    {
        _cacheManager = cacheManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var dataCache = await _cacheManager.DataCache.Get();

        var model = new AreaChartViewModel
        {
            TitleText = "Cumulative RPI Quarterly",
            YAxisTitleText = "% Change",
            Id = "chartRPI",
            Data = new List<Series>(),
            Stacking =PlotOptionsAreaStacking.Normal
        };

        var data = dataCache.InflationRpiGroupChanges.ToArray();
        var columns = data
            .Select(x => x.Type)
            .Distinct()
            .OrderBy(x => x)
            .ToArray();

        var counters = new double[columns.Length];

        for (var i = 0; i < columns.Length; i++)
        {
            var columnSeries = columns[i];
            model.Data.Add(new AreaSeries
            {
                Name = columnSeries,
                ShowInLegend = true,
                Data = new List<AreaSeriesData>()
            });
            counters[i] = 100;
        }
        
        for (var colIndex = 0; colIndex < columns.Length; colIndex++)
        {
            var t = columns[colIndex];
            
            var columnRows = data
                .Where(x => x.Type == t)
                .OrderBy(x => x.ParsedYear)
                .ThenBy(x => x.ParsedQtr)
                .ToArray();
            
            foreach (var row in columnRows)
            {
                var value = row.QuarterlyChange ?? 0;

                var fract = counters[colIndex] / 100D * value;
                value = fract + counters[colIndex];


                ((AreaSeries)model.Data[colIndex]).Data.Add(new AreaSeriesData
                {
                    Y = value
                });

                counters[colIndex] = value;
            }
        }

        model.Data = model.Data.OrderBy(x => ((AreaSeries)x).Data.Last().Y).ToList();

        var yearQtrs = data
            .Select(x => new { Y = x.ParsedYear, Q = x.ParsedQtr })
            .Distinct()
            .OrderBy(x => x.Y)
            .ThenBy(x => x.Q)
            .ToArray();

        model.Labels = new List<string>();
        foreach (var yq in yearQtrs)
        {
            var anyGrouping = $"{yq.Y} {yq.Q}";
            model.Labels.Add(anyGrouping);
        }
        


        return View(model);
    }
}
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataGg.Core.Attributes;
using DataGg.Core.Extensions;
using DataGg.Web.Models;
using DataGg.Web.Services;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc;

namespace DataGg.Web.ViewComponents;

public class GenericAreaChartViewComponent : ViewComponent
{
    private readonly CacheManager _cacheManager;

    public GenericAreaChartViewComponent(CacheManager cacheManager)
    {
        _cacheManager = cacheManager;
    }

    public async Task<IViewComponentResult> InvokeAsync(string id, string title, Type type, string groupName = "")
    {
        var dataCache = await _cacheManager.DataCache.Get();

        var model = new AreaChartViewModel
        {
            TitleText = title,
            YAxisTitleText = title,
            Id = id,
            Data = new List<Series>()
        };

        var chartingData = dataCache.GetChartingDataForType(type);
        var columns = chartingData.ColumnsFiltered(groupName);

        var counters = new double?[columns.Length];

        for (var i = 0; i < columns.Length; i++)
        {
            var columnSeries = columns[i];
            model.Data.Add(new AreaSeries
            {
                Name = columnSeries.DisplayName,
                ShowInLegend = true,
                Data = new List<AreaSeriesData>()
            });


            counters[i] = 100;
        }

        model.Labels = new List<string>();

        foreach (var row in chartingData.OrderedItems)
        {
            var hasData = false;

            for (var i = 0; i < columns.Length; i++)
            {
                var column = columns[i];

                var value = column.PropertyInfo.GetValueAsDouble(row);

                if (value.HasValue)
                {
                    hasData = true;

                    if (column.CalcMethod == CalcMethod.PercentChange)
                    {
                        var fract = counters[i] / 100D * value;
                        value = fract + counters[i];
                    }

                    ((AreaSeries)model.Data[i]).Data.Add(new AreaSeriesData
                    {
                        Y = value
                    });

                    counters[i] = value ?? 100;
                }
            }

            if (hasData)
            {
                model.Labels.Add(string.Format("{0: " + chartingData.GroupingColumn.Format + "}",
                    chartingData.GroupingColumn.PropertyInfo.GetValue(row)));
            }
        }

        return View(model);
    }
}
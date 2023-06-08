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
    public class TransportRegisteredVehiclesChartViewComponent : ViewComponent
    {

        private readonly CacheManager _cacheManager;

        public TransportRegisteredVehiclesChartViewComponent(CacheManager cacheManager)
        {

            _cacheManager = cacheManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
        var dataCache = await _cacheManager.DataCache.Get();

        var model = new AreaChartViewModel
        {
            TitleText = "Registered Vehicles", YAxisTitleText = "Registered Vehicles", Id = "chartRegisteredVehicles",
            Stacking = PlotOptionsAreaStacking.Normal
        };

        var motorVehiclePrivate = new List<AreaSeriesData>();
        var motorVehicleCommercial = new List<AreaSeriesData>();
        var motorCycles = new List<AreaSeriesData>();


        model.Data = new List<Series>
        {
            new AreaSeries { Name = "Motor Vehicle Private", Data = motorVehiclePrivate },
            new AreaSeries { Name = "Motor Vehicle Commercial", Data = motorVehicleCommercial },
            new AreaSeries { Name = "Motor Cycles", Data = motorCycles },
        
        };
        model.Labels = new List<string>();

        foreach (var qtr in dataCache.TransportRegisteredVehicles.OrderBy(y => y.Year))
        {
            motorVehiclePrivate.Add(new AreaSeriesData
            {
                Y = qtr.MotorVehiclesPrivate
            });

            motorVehicleCommercial.Add(new AreaSeriesData
            {
                Y = qtr.MotorVehiclesCommercial
            });

            motorCycles.Add(new AreaSeriesData
            {
                Y = qtr.MotorCycles
            });

            
            model.Labels.Add($"{qtr.Year}");
        }

        return View(model);
        }
    }
}

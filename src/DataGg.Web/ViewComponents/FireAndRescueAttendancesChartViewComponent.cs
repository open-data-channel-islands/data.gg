using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Web.Models;
using DataGg.Web.Services;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc;

namespace DataGg.Web.ViewComponents;

public class FireAndRescueAttendancesChartViewComponent : ViewComponent
{
    private readonly CacheManager _cacheManager;

    public FireAndRescueAttendancesChartViewComponent(CacheManager cacheManager)
    {
        _cacheManager = cacheManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var dataCache = await _cacheManager.DataCache.Get();

        var model = new AreaChartViewModel
        {
            TitleText = "Attendances", YAxisTitleText = "Attendances", Id = "chartAttendances",
            Stacking = PlotOptionsAreaStacking.Normal
        };

        var allOtherTypesOfFire = new List<AreaSeriesData>();
        var chimneyFires = new List<AreaSeriesData>();
        var falseAlarmsGeneral = new List<AreaSeriesData>();
        var falseAlarmsMalicious = new List<AreaSeriesData>();

        var specialServicesEmergency = new List<AreaSeriesData>();
        var specialServicesNonEmergency = new List<AreaSeriesData>();
        var specialServicesRoadCollisions = new List<AreaSeriesData>();
        var specialServicesGeneral = new List<AreaSeriesData>();

        model.Data = new List<Series>
        {
            new AreaSeries { Name = "All other types of fires", Data = allOtherTypesOfFire },
            new AreaSeries { Name = "Chimney fires", Data = chimneyFires },
            new AreaSeries { Name = "False alarms general", Data = falseAlarmsGeneral },
            new AreaSeries { Name = "False alarms malicious", Data = falseAlarmsMalicious },

            new AreaSeries { Name = "Special service emergency", Data = specialServicesEmergency },
            new AreaSeries { Name = "Special service non-emergency", Data = specialServicesNonEmergency },
            new AreaSeries { Name = "Special service Road Traffic Collisions", Data = specialServicesRoadCollisions },
            new AreaSeries { Name = "Special service General", Data = specialServicesGeneral }
        };
        model.Labels = new List<string>();

        foreach (var qtr in dataCache.FireAndRescueAttendances.OrderBy(y => y.Year))
        {
            allOtherTypesOfFire.Add(new AreaSeriesData
            {
                Y = qtr.AllOtherTypesOfFires
            });

            chimneyFires.Add(new AreaSeriesData
            {
                Y = qtr.ChimneyFires
            });

            falseAlarmsGeneral.Add(new AreaSeriesData
            {
                Y = qtr.FalseAlarmsGeneral
            });

            falseAlarmsMalicious.Add(new AreaSeriesData
            {
                Y = qtr.FalseAlarmsMalicious
            });

            specialServicesEmergency.Add(new AreaSeriesData
            {
                Y = qtr.SpecialServiceEmergency
            });

            specialServicesNonEmergency.Add(new AreaSeriesData
            {
                Y = qtr.SpecialServiceNonEmergency
            });

            specialServicesRoadCollisions.Add(new AreaSeriesData
            {
                Y = qtr.SpecialServiceRoadTrafficCollisions
            });

            specialServicesGeneral.Add(new AreaSeriesData
            {
                Y = qtr.SpecialServiceGeneral
            });


            model.Labels.Add($"{qtr.Year}");
        }

        return View(model);
    }
}
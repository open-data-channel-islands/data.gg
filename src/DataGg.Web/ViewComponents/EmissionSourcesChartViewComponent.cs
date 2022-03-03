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
    public class EmissionSourcesChartViewComponent : ViewComponent
    {

        private readonly CacheManager _cacheManager;

        public EmissionSourcesChartViewComponent(CacheManager cacheManager)
        {

            _cacheManager = cacheManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var dataCache = await _cacheManager.DataCache.Get();

            var model = new LineChartViewModel() { TitleText = "Sources", YAxisTitleText = "Sources", Id = "chartSources" };

            var energyPowerGeneration = new List<LineSeriesData>();
            var energyIndustrialCombustion = new List<LineSeriesData>();
            var energyTransport = new List<LineSeriesData>();
            var energyCommercialAndDomesticCombusiton = new List<LineSeriesData>();
            var agriculturalLandUseLandUseChangeAndForestry = new List<LineSeriesData>();
            var waste = new List<LineSeriesData>();
            var fluorinatedGases = new List<LineSeriesData>();
            var other = new List<LineSeriesData>();

            model.Data = new List<Series>
            {
                new LineSeries { Name = "Power Generation", Data = energyPowerGeneration },
                new LineSeries { Name = "Industrial Combustion", Data = energyIndustrialCombustion },
                new LineSeries { Name = "Transport", Data = energyTransport },
                new LineSeries
                    { Name = "Commercial & Domestic Combustion", Data = energyCommercialAndDomesticCombusiton },
                new LineSeries
                {
                    Name = "Agricultural Land Use and Use Change And Forestry",
                    Data = agriculturalLandUseLandUseChangeAndForestry
                },
                new LineSeries { Name = "Waste", Data = waste },
                new LineSeries { Name = "Fluorinated Gases", Data = fluorinatedGases },
                new LineSeries { Name = "other", Data = other },
            };
            
            model.Labels = new List<string>();

            foreach (var qtr in dataCache.EmissionSource.OrderBy(y => y.Year))
            {
                energyPowerGeneration.Add(new LineSeriesData { Y = qtr.EnergyPowerGeneration });
                energyIndustrialCombustion.Add(new LineSeriesData { Y = qtr.EnergyIndustrialCombustion });
                energyTransport.Add(new LineSeriesData { Y = qtr.EnergyTransport });
                energyCommercialAndDomesticCombusiton.Add(new LineSeriesData { Y = qtr.EnergyCommercialAndDomesticCombusiton });
                agriculturalLandUseLandUseChangeAndForestry.Add(new LineSeriesData { Y = qtr.AgriculturalLandUseLandUseChangeAndForestry });
                waste.Add(new LineSeriesData { Y = qtr.Waste });
                fluorinatedGases.Add(new LineSeriesData { Y = qtr.FluorinatedGases });
                other.Add(new LineSeriesData { Y = qtr.Other });
                
                model.Labels.Add($"{qtr.Year}");

            }

            return View(model);
        }
    }
}

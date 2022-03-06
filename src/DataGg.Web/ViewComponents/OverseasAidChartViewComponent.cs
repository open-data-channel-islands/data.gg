using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Web.Models;
using DataGg.Web.Services;
using Highsoft.Web.Mvc.Charts;
using Microsoft.AspNetCore.Mvc;

namespace DataGg.Web.ViewComponents;

public class OverseasAidChartViewComponent : ViewComponent
{
    private readonly CacheManager _cacheManager;

    public OverseasAidChartViewComponent(CacheManager cacheManager)
    {
        _cacheManager = cacheManager;
    }

    public async Task<IViewComponentResult> InvokeAsync()
    {
        var dataCache = await _cacheManager.DataCache.Get();

        var model = new StackedAreaChartViewModel() { TitleText = "Overseas Aid", YAxisTitleText = "Overseas Aid", Id = "chartOverseasAid" };
        
        var africaAid = new List<AreaSeriesData>();
        var africaEmergency = new List<AreaSeriesData>();
        
        var europeAid = new List<AreaSeriesData>();
        var europeEmergency = new List<AreaSeriesData>();
        
        var indianSubContinentAid = new List<AreaSeriesData>();
        var indianSubContinentEmergency = new List<AreaSeriesData>();
             
        var latinAmericaCaribbeanAid = new List<AreaSeriesData>();
        var latinAmericaCaribbeanEmergency = new List<AreaSeriesData>();   
             
        var middleEastAid = new List<AreaSeriesData>();
        var middleEastEmergency = new List<AreaSeriesData>();
        
        var otherAsiaPacificAid = new List<AreaSeriesData>();
        var otherAsiaPacificEmergency = new List<AreaSeriesData>();
        
        model.Data = new List<Series>
        {
            new AreaSeries { Name = "Africa Aid", Data = africaAid },
            new AreaSeries { Name = "Africa Emergency Relief", Data = africaEmergency },
            
            new AreaSeries { Name = "Europe Aid", Data = europeAid },
            new AreaSeries { Name = "Europe Emergency Relief", Data = europeEmergency },            
            
            new AreaSeries { Name = "Indian Sub-Continent Aid", Data = indianSubContinentAid },
            new AreaSeries { Name = "Indian Sub-Continent Emergency Relief", Data = indianSubContinentEmergency },
            
            new AreaSeries { Name = "Latin America & Caribbean Aid", Data = latinAmericaCaribbeanAid },
            new AreaSeries { Name = "Latin America & Caribbean Emergency Relief", Data = latinAmericaCaribbeanEmergency },
            
            new AreaSeries { Name = "Other Asia & Pacific Aid", Data = otherAsiaPacificAid },
            new AreaSeries { Name = "Other Asia & Pacific Emergency Relief", Data = otherAsiaPacificEmergency },
            
            new AreaSeries { Name = "Middle East Aid", Data = middleEastAid },
            new AreaSeries { Name = "Middle East Emergency Relief", Data = middleEastEmergency },

        };
        model.Labels = new List<string>();

        foreach (var qtr in dataCache.OverseasContributions.OrderBy(y => y.Year))
        {

            africaAid.Add(new AreaSeriesData
            {
                Y = qtr.AfricaAid
            });

            africaEmergency.Add(new AreaSeriesData
            {
                Y = qtr.AfricaEmergencyRelief
            });
            
            europeAid.Add(new AreaSeriesData
            {
                Y = qtr.EuropeAid
            });

            europeEmergency.Add(new AreaSeriesData
            {
                Y = qtr.EuropeEmergencyRelief
            });
            
            indianSubContinentAid.Add(new AreaSeriesData
            {
                Y = qtr.IndianSubContinentAid
            });

            indianSubContinentEmergency.Add(new AreaSeriesData
            {
                Y = qtr.IndianSubContinentEmergencyRelief
            });
            
            latinAmericaCaribbeanAid.Add(new AreaSeriesData
            {
                Y = qtr.LatinAmericaAndCaribbeanAid
            });

            latinAmericaCaribbeanEmergency.Add(new AreaSeriesData
            {
                Y = qtr.LatinAmericaAndCaribbeanEmergencyRelief
            });
            
            otherAsiaPacificAid.Add(new AreaSeriesData
            {
                Y = qtr.OtherAsiaAndPacificAid
            });

            otherAsiaPacificEmergency.Add(new AreaSeriesData
            {
                Y = qtr.OtherAsiaAndPacificEmergencyRelief
            });
            
            middleEastAid.Add(new AreaSeriesData
            {
                Y = qtr.MiddleEastAid
            });
            
            middleEastEmergency.Add(new AreaSeriesData
            {
                Y = qtr.MiddleEastEmergencyRelief
            });



            model.Labels.Add($"{qtr.Year}");
        }

        return View(model);
    }
}
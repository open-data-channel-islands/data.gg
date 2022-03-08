using System.Collections.Generic;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace DataGg.Web.Models;

public class AreaChartViewModel
{
    public List<Series> Data { get; set; }
    public List<string> Labels { get; set; }
    public string TitleText { get; set; }
    public string YAxisTitleText { get; set; }
    public string Id { get; set; } = "chart";
    public PlotOptionsAreaStacking Stacking { get; set; } = PlotOptionsAreaStacking.Null;

    public HighchartsRenderer Build()
    {
        var chartOptions = new Highcharts
        {
            Credits = new Credits { Enabled = false },
            Chart = new Chart { BackgroundColor = "transparent" },

            Title = new Title
            {
                Text = TitleText
            },
            Tooltip = new Tooltip()
            {
                ValueDecimals = 2
            },
            XAxis = new List<XAxis>
            {
                new()
                {
                    AllowDecimals = false,
                    Categories = Labels
                    //Labels = new XAxisLabels { Step = 12@*, Rotation = -40*@ }
                }
            },
            YAxis = new List<YAxis>
            {
                new()
                {
                    Labels = new YAxisLabels
                    {
                        //Formatter ="{0:n2}", 
                        //Format = "{0:n2}"
                    },
                    Title = new YAxisTitle
                    {
                        Text = YAxisTitleText
                    }
                }
            },
            /*                Tooltip = new Tooltip
                            {
                                PointFormat = "<b>{point.y:,.0f}</b> passangers"
                            },*/
            PlotOptions = new PlotOptions
            {
                Area = new PlotOptionsArea
                {
                    Marker = new PlotOptionsAreaMarker
                    {
                        Enabled = false,
                        Symbol = "circle",
                        Radius = 2,
                        States = new PlotOptionsAreaMarkerStates
                        {
                            Hover = new PlotOptionsAreaMarkerStatesHover
                            {
                                Enabled = true
                            }
                        }
                    },
                    Stacking = Stacking
                }
            },
            Series = Data
        };

        chartOptions.ID = Id;
        var renderer = new HighchartsRenderer(chartOptions);
        return renderer;
    }
}
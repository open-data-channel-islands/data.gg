using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGg.Web.Models
{
    public class StackedAreaChartViewModel
    {
        public List<Series> Data { get; set; }
        public List<string> Labels { get; set; }
        public string TitleText { get; set; }
        public string YAxisTitleText { get; set; }
        public string Id { get; set; } = "chart";

        public HighchartsRenderer Build()
        {
            var chartOptions = new Highcharts
            {
                Credits = new() { Enabled = false },
                Chart = new() { BackgroundColor = "transparent" },

                Title = new Title
                {
                    Text = TitleText
                },
                XAxis = new List<XAxis>
{
                new XAxis
                {
                    AllowDecimals = false,
                    Categories = Labels,
                    //Labels = new XAxisLabels { Step = 12@*, Rotation = -40*@ }
                }
            },
                YAxis = new List<YAxis> {
                new YAxis
                {
                    Title = new YAxisTitle
                    {
                        Text = YAxisTitleText
                    },
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
                        Stacking = PlotOptionsAreaStacking.Normal,
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
                        }

                    }
                },
                Series = Data
            };

            chartOptions.ID = Id;
            var renderer = new HighchartsRenderer(chartOptions);
            return renderer;
        }
    }
}

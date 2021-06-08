using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DataGg.Core.Types;
using DataGg.Web.Models;
using DataGg.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Serilog;

namespace DataGg.Web.Areas.Developers.Pages
{
    public class DataViewModel : BreadcrumPageModel
    {
        private readonly CacheManager _cacheManager;

        public bool Error { get; set; } = false;
        public DataCategoryDto DataCategory { get; set; }
        public DataSetDto DataSet { get; set; }
        public DataTable DataTable { get; set; }

        public DataViewModel(CacheManager cacheManager)
        {
            Breadcrums.Add(new Breadcrum("Developers", "/Developers"));
            _cacheManager = cacheManager;
        }

        public async Task OnGetAsync(string dataCategoryStub, string dataSetStub)
        {
            Breadcrums.Add(new Breadcrum(dataCategoryStub, $"/Developers/{dataCategoryStub}"));
            Breadcrums.Add(new Breadcrum("View", $"/Developers/{dataCategoryStub}/{dataSetStub}"));

            var dataCategories = await _cacheManager.DataCategories.Get();

            var stubDataCategory = dataCategories
                .FirstOrDefault(dc => dc.Stub.Equals(dataCategoryStub, StringComparison.OrdinalIgnoreCase));

            if (stubDataCategory == null)
            {
                return;
            }

            DataCategory = stubDataCategory;

            var stubDataSet = DataCategory.DataSets
                .FirstOrDefault(ds => ds.Stub.Equals(dataSetStub, StringComparison.OrdinalIgnoreCase));

            DataSet = stubDataSet;

            if (DataSet == null)
            {
                return;
            }

            try
            {
                if (DataSet.Live)
                {
                    var liveData = await _cacheManager.GetLiveDataCache();

                    var json = string.Empty;

                    switch (DataSet.Filename)
                    {
                        case LiveDataCache.FlightsArrivals:
                            json = System.Text.Json.JsonSerializer.Serialize(liveData.AirportArrivals);
                            break;
                        case LiveDataCache.FlightsDepartures:
                            json = System.Text.Json.JsonSerializer.Serialize(liveData.AirportDepartures);
                            break;
                        case LiveDataCache.SailingsHarbour:
                            json = System.Text.Json.JsonSerializer.Serialize(liveData.Harbour);
                            break;
                    }
                    
                    DataTable = JsonConvert.DeserializeObject<DataTable>(json);
                }
                else
                {
                    DataTable = JsonConvert.DeserializeObject<DataTable>(DataSet.CurrentDataJson.Json);
                }
            }
            catch(Exception ex)
            {
                Log.Error(ex, "Exception parsing JSON to DataTable [{dataCategoryStub} - {dataSetStub}]",
                    dataCategoryStub, dataSetStub);
                Error = true;

            }

        }
    }
}

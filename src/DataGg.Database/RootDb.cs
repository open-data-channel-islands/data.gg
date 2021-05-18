using Dapper;
using DataGg.Core.Types;
using Microsoft.Extensions.Configuration;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DataGg.Database
{
    public class RootDb : DatabaseBase
    {
        public RootDb(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<DataCategoryDto[]> GetData()
        {
            await using var conn = await OpenConnectionAsync();

            var selectBlocks = await conn.QueryMultipleAsync("dbo.GetData", 
                commandType: System.Data.CommandType.StoredProcedure);

            var dataCategories = await selectBlocks.ReadAsync<DataCategoryDto>();
            var dataSets = await selectBlocks.ReadAsync<DataSetDto>();
            var dataJsons = await selectBlocks.ReadAsync<DataJson>();

            // stich up the parent/childs
            foreach(var dc in dataCategories)
            {
                dc.DataSets = dataSets.Where(ds => ds.DataCategoryId == dc.Id).ToArray();
            }

            foreach (var ds in dataSets)
            {
                ds.DataJsons = dataJsons.Where(dj => dj.DataSetId == ds.Id).ToArray();
            }

            return dataCategories.ToArray();
        }

        public async Task InsertDataJson(DataJson dataJson)
        {
            await using var conn = await OpenConnectionAsync();

            await conn.ExecuteAsync("dbo.InsertDataJson", 
                new
            {
                dataJson.DataSetId,
                dataJson.Stamp,
                dataJson.Json
            },
            commandType: System.Data.CommandType.StoredProcedure);
        }

/*        public async Task InsertAllDataJson()
        {
            var data = await GetData();

            foreach (var dc in data)
            {
                foreach (var ds in dc.DataSets)
                {
                    if (ds.Live)
                    {
                        continue;
                    }

                    var jsonFromFile = GetResourceTextFile(ds.Filename.Replace("/", "."));

                    var obj = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonFromFile);
                    var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(obj);

                    var dataJson = new DataJson
                    {
                        DataSetId = ds.Id,
                        Draft = false,
                        Stamp = DateTime.Today,
                        Json = jsonString.ToString()
                    };

                    await InsertDataJson(dataJson);
                }
            }
        }

        private string GetResourceTextFile(string filename)
        {
            using var stream = GetType().Assembly.GetManifestResourceStream($"DataGg.Database.Guernsey.{filename}");

            using var sr = new System.IO.StreamReader(stream);

            return sr.ReadToEnd();
        }*/
    }
}

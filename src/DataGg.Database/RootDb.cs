using Dapper;
using DataGg.Core.Types;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
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
            var dataSets = await selectBlocks.ReadAsync<DataSet>();

            // stich up the parent/childs
            foreach(var dc in dataCategories)
            {
                dc.DataSets = dataSets.Where(ds => ds.DataCategoryId == dc.Id).ToArray();
            }

            return dataCategories.ToArray();
        }
    }
}

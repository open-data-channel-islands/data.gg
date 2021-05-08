using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGg.Database
{
    public abstract class DatabaseBase
    {
        protected readonly string _connStr;

        internal DatabaseBase(IConfiguration configuration)
        {
            _connStr = configuration.GetConnectionString("DefaultConnection");
        }

        protected async Task<SqlConnection> OpenConnectionAsync()
        {
            return await OpenConnectionAsync(_connStr);
        }

        public static async Task<SqlConnection> OpenConnectionAsync(string connStr)
        {
            var connection = new SqlConnection(connStr);
            await connection.OpenAsync();
            return connection;
        }
    }
}

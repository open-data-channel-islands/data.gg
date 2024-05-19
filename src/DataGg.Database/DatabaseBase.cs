using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace DataGg.Database
{
    public abstract class DatabaseBase
    {
        private readonly string _connStr;

        internal DatabaseBase(IConfiguration configuration)
        {
            _connStr = configuration.GetConnectionString("DefaultConnection");
        }

        protected async Task<SqlConnection> OpenConnectionAsync()
        {
            return await OpenConnectionAsync(_connStr);
        }

        private static async Task<SqlConnection> OpenConnectionAsync(string connStr)
        {
            var connection = new SqlConnection(connStr);
            await connection.OpenAsync();
            return connection;
        }
    }
}

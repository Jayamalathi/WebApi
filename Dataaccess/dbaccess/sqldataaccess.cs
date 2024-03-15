using Dapper;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace dataaccess.dbaccess
{
    public class sqldataaccess : Isqldataaccess
    {
        private readonly IConfiguration _config;

        public sqldataaccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(
            string storedProcedure,
            U parameters,
            string connectionId = "Default")
            where U : class
        {
            try
            {
                using IDbConnection connection = new SqlConnection(
                        connectionString: _config.GetConnectionString(connectionId));

                return await connection.QueryAsync<T>(
                    sql: storedProcedure,
                    param: parameters,
                    commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Task<IEnumerable<T1>> LoadData<T1, T2>(string storedProcedure)
        {
            return null;
        }

        public async Task Savedata<T>(
            string storedProcedure,
            T parameters,
            string connectionId = "Default")
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
            await connection.ExecuteAsync(storedProcedure, parameters,
                commandType: CommandType.StoredProcedure);
        }
    }

}

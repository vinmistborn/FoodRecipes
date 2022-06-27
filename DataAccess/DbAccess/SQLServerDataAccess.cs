using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DbAccess
{
    public class SQLServerDataAccess : ISQLServerDataAccess
    {
        private readonly IConfiguration _config;

        public SQLServerDataAccess(IConfiguration config)
        {
            _config = config;
        }

        /// <summary>
        /// Loads Data from the database
        /// </summary>
        /// <typeparam name="T">Table that should be loaded</typeparam>
        /// <typeparam name="U">Parameters to include in the query</typeparam>
        /// <param name="storedProcudure"></param>
        /// <param name="parameters"></param>
        /// <param name="connectionString">database connection string in the appsettings.json</param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> LoadData<T, U>(
            string storedProcudure,
            U parameters,
            string connectionString = "Default"
            )
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionString));

            return await connection.QueryAsync<T>(storedProcudure, parameters, commandType: CommandType.StoredProcedure);
        }

        /// <summary>
        /// Performs a query against the database (e.g INSERT, UPDATE, DELETE)
        /// </summary>
        /// <typeparam name="T">Table</typeparam>
        /// <param name="storedProcudure"></param>
        /// <param name="parameters"></param>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public async Task SaveData<T>(
            string storedProcudure,
            T parameters,
            string connectionString = "Default"
            )
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionString));

            await connection.ExecuteAsync(storedProcudure, parameters, commandType: CommandType.StoredProcedure);
        }
    }
}

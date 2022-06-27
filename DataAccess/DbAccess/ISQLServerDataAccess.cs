using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccess.DbAccess
{
    public interface ISQLServerDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storedProcudure, U parameters, string connectionString = "Default");
        Task SaveData<T>(string storedProcudure, T parameters, string connectionString = "Default");
    }
}
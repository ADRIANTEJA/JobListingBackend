
namespace DataAccess
{
    public interface ISQLAccess
    {
        Task<List<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters, string connectionStringName);
        Task<int> SaveDataAsync<U>(string storedProcedure, U parameters, string connectionStringName);
    }
}
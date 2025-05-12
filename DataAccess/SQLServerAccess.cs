using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataAccess;

public class SQLServerAccess : ISQLAccess
{
    private readonly IConfiguration _config;

    public SQLServerAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<List<T>> LoadDataAsync<T, U>(string storedProcedure,
                                                   U parameters,
                                                   string connectionStringName)
    {
        string connectionString = _config.GetConnectionString(connectionStringName)!; 
 
        using var connection = new SqlConnection(connectionString);

        var rows = await connection.QueryAsync<T>(storedProcedure,
                                                  parameters,
                                                  commandType: CommandType.StoredProcedure);

        return rows.ToList();
    }

    public async Task<int> SaveDataAsync<U>(string storedProcedure,
                                            U parameters,
                                            string connectionStringName)
    {
        string connectionString = _config.GetConnectionString(connectionStringName)!;

        using var connection = new SqlConnection(connectionString);

        return await connection.ExecuteAsync(storedProcedure,
                                           parameters,
                                           commandType: CommandType.StoredProcedure);
    }
}

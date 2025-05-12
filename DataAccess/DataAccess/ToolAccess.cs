

using DataAccess.DataModels;

namespace DataAccess.DataAccess;

public class ToolAccess : IToolAccess
{
    private readonly ISQLAccess _dbAccess;
    private readonly ConnectionStringData _connectionStringData;

    public ToolAccess(ISQLAccess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }

    public Task<List<ToolModel>> LoadToolsByJobListingId(int jobListingId)
    {
        return _dbAccess.LoadDataAsync<ToolModel, dynamic>("dbo.spJobListing_AllTools",
                                                             new { JobListingId = jobListingId },
                                                             _connectionStringData.SqlConnectionName);
    }
}

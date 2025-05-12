using DataAccess.DataModels;

namespace DataAccess.DataAccess;

public class JobListingAccess : IJobListingAccess
{
    private readonly ISQLAccess _dbAccess;
    private readonly ConnectionStringData _connectionStringData;

    public JobListingAccess(ISQLAccess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }

    public Task<List<JobListingModel>> LoadAllJobListings()
    {
        return _dbAccess.LoadDataAsync<JobListingModel, dynamic>("dbo.spJobListing_All",
                                                                 new { },
                                                                 _connectionStringData.SqlConnectionName);
    }
}

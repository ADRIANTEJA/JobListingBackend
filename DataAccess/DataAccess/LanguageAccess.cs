using DataAccess.DataModels;

namespace DataAccess.DataAccess;

public class LanguageAccess : ILanguageAccess
{
    private readonly ISQLAccess _dbAccess;
    private readonly ConnectionStringData _connectionStringData;

    public LanguageAccess(ISQLAccess dbAccess, ConnectionStringData connectionStringData)
    {
        _dbAccess = dbAccess;
        _connectionStringData = connectionStringData;
    }

    public Task<List<LanguageModel>> LoadLanguagesByJobListingId(int jobListingId)
    {
        return _dbAccess.LoadDataAsync<LanguageModel, dynamic>("dbo.spJobListing_AllLanguages",
                                                                new { JobListingId = jobListingId },
                                                                _connectionStringData.SqlConnectionName);
    }
}

using DataAccess.DataModels;

namespace DataAccess.DataAccess
{
    public interface IJobListingAccess
    {
        Task<List<JobListingModel>> LoadAllJobListings();
    }
}

using DataAccess.DataModels;

namespace DataAccess.DataAccess
{
    public interface IToolAccess
    {
        Task<List<ToolModel>> LoadToolsByJobListingId(int jobListingId);
    }
}
using DataAccess.DataModels;

namespace DataAccess.DataAccess
{
    public interface ILanguageAccess
    {
        Task<List<LanguageModel>> LoadLanguagesByJobListingId(int jobListingId);
    }
}
using DataAccess.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace JobListingAPI.Endpoints;

public static class JobListingEndpoint
{
    public static void AddJobListingEnpoints(this WebApplication app)
    {
        app.MapGet("/joblistings", RequestJobListings);
    }

    public static async Task<IResult> RequestJobListings([FromServices] IJobListingAccess jobListingAccess,
                                                         [FromServices] IToolAccess toolAccess,
                                                         [FromServices] ILanguageAccess languageAccess)
    {
        var jobListings = await jobListingAccess.LoadAllJobListings();

        foreach (var jobListing in jobListings)
        {
            jobListing.Languages = await languageAccess.LoadLanguagesByJobListingId(jobListing.Id);
            jobListing.Tools = await toolAccess.LoadToolsByJobListingId(jobListing.Id);
        }

        return Results.Ok(jobListings);
    }
}

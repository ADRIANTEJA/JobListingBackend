using Scalar.AspNetCore;

namespace JobListingAPI.Startup;

public static class OpenAPIConfig
{
    public static void AddOpenApiServices(this IServiceCollection services)
    {
        services.AddOpenApi();
    }

    public static void UseOpenAPI(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.MapScalarApiReference(options =>
            {
                options.Title = "Job Listing API";
                options.HideClientButton = true;
                options.Layout = ScalarLayout.Modern;
            });
        }
    }
}

using DataAccess;
using DataAccess.DataAccess;

namespace JobListingAPI.Startup;

public static class DependencyInjectionConfig
{
    public static void AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApiServices();
        builder.Services.AddCorsServices();
        builder.Services.AddSingleton<ConnectionStringData>();
        builder.Services.AddSingleton<ISQLAccess, SQLServerAccess>();
        builder.Services.AddSingleton<IJobListingAccess, JobListingAccess>();
        builder.Services.AddSingleton<ILanguageAccess, LanguageAccess>();
        builder.Services.AddSingleton<IToolAccess, ToolAccess>();
    }
}

namespace JobListingAPI.Startup;

public static class CorsConfig
{
    private const string AllowDevServerPolicy = "AllowDevServer";

    public static void AddCorsServices(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(AllowDevServerPolicy, policy =>
            {
                policy.WithOrigins("http://127.0.0.1:5500")
                .AllowAnyHeader()
                .AllowAnyMethod();
            });
        });
    }

    public static void ApplyCorsConfig(this WebApplication app)
    {
        app.UseCors(AllowDevServerPolicy);
    }
}

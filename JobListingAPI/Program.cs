using JobListingAPI.Endpoints;
using JobListingAPI.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.AddServices();

var app = builder.Build();

app.UseOpenAPI();

app.ApplyCorsConfig();

app.UseHttpsRedirection();

app.AddJobListingEnpoints();

app.Run();

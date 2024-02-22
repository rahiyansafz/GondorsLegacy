using GondorsLegacy.Application;
using GondorsLegacy.Infrastructure.Caching;
using GondorsLegacy.Infrastructure.Contracts;
using GondorsLegacy.Infrastructure.DateTimes;
using GondorsLegacy.Infrastructure.Interceptors;
using GondorsLegacy.Infrastructure.Services;
using GondorsLegacy.Infrastructure.Web.MinimalApis;
using GondorsLegacy.Services.HotelInformation;
using GondorsLegacy.Services.HotelInformation.Configuration;
using GondorsLegacy.Services.HotelInformation.Services.Abstract;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.OpenApi.Models;
using Refit;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var appSettings = builder.Configuration.GetSection("RapidAPI").Get<AppSettings>();

builder.Services.AddApiService(builder.Configuration);
builder.Services.AddRefitClient<IExchangeRateApi>()
    .ConfigureHttpClient(c =>
    {
        c.BaseAddress = new Uri(appSettings.ApiHost);
        c.DefaultRequestHeaders.Add("X-RapidAPI-Key", appSettings.ApiKey);
        c.DefaultRequestHeaders.Add("X-RapidAPI-Host", "apidojo-booking-v1.p.rapidapi.com");
    });

builder.Services.AddRefitClient<IBookingApi>()
    .ConfigureHttpClient(c =>
    {
        c.BaseAddress = new Uri(appSettings.ApiHost);
        c.DefaultRequestHeaders.Add("X-RapidAPI-Key", appSettings.ApiKey);
        c.DefaultRequestHeaders.Add("X-RapidAPI-Host", "apidojo-booking-v1.p.rapidapi.com");
    });

builder.Services.AddContractsService();
builder.Services.AddControllers();
builder.Services.AddInterceptors();
builder.Services.AddHotelModule(builder.Configuration);
builder.Services.AddDateTimeProvider();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApplicationServices();
builder.Services.AddCaches(builder.Configuration);

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API Documentation",
        Version = "v1",
        Description = "Hotel Information Service",
        Contact = new OpenApiContact
        {
            Name = "Rahiyan Safin",
            Email = "rahiyansafin@gmail.com",
            Url = new Uri("https://rahiyansafin.vercel.app")
        }
    });
});

builder.Services.AddHealthChecks()
    .AddSqlServer(builder.Configuration.GetConnectionString("HotelDatabase"));

var app = builder.Build();

app.MapHealthChecks("/health",
    new HealthCheckOptions
    {
        ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse,
        AllowCachingResponses = false,
        ResultStatusCodes = new Dictionary<HealthStatus, int>
        {
            { HealthStatus.Healthy, 200 },
            { HealthStatus.Degraded, 503 },
            { HealthStatus.Unhealthy, 500 }
        }
    });

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();
app.MapEndpointHandlers(Assembly.GetCallingAssembly());

app.Run();
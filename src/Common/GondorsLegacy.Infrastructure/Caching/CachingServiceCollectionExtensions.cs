using GondorsLegacy.CrossCuttingCorners.Caching;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GondorsLegacy.Infrastructure.Caching;

public static class CachingServiceCollectionExtensions
{
    public static IServiceCollection AddCaches(this IServiceCollection services, IConfiguration configuration)
    {
        configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var redisConfiguration = configuration.GetSection("Redis:Configuration").Value;
        var redisInstanceName = configuration.GetSection("Redis:InstanceName").Value;

        services.AddStackExchangeRedisCache(options =>
        {
            options.Configuration = redisConfiguration;
            options.InstanceName = redisInstanceName;
        });
        services.AddScoped<ICache, CacheService>();
        return services;
    }
}
using Castle.DynamicProxy;
using Microsoft.Extensions.DependencyInjection;

namespace GondorsLegacy.Infrastructure.Interceptors;

public static class InterceptorServiceCollectionExtensions
{
    public static IServiceCollection AddInterceptors(this IServiceCollection services)
    {
        services.AddScoped<LoggingInterceptor>();

        services.AddTransient<IProxyGenerator, ProxyGenerator>();

        return services;
    }
}
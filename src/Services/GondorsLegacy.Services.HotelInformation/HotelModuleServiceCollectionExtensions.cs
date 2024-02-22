﻿using AutoMapper;
using GondorsLegacy.Domain.Repositories;
using GondorsLegacy.Infrastructure.Monitoring.OpenTelemetry;
using GondorsLegacy.Services.HotelInformation.Mappers;
using GondorsLegacy.Services.HotelInformation.RateLimiterPolicies;
using GondorsLegacy.Services.HotelInformation.Repositories;
using GondorsLegacy.Services.HotelInformation.Validations;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GondorsLegacy.Services.HotelInformation;

public static class HotelModuleServiceCollectionExtensions
{
    public static IServiceCollection AddHotelModule(this IServiceCollection services, IConfiguration Configuration)
    {
        services.AddScoped<IRepository<Entities.Hotel, Guid>, Repository<Entities.Hotel, Guid>>();

        services.AddScoped<IHotelRepository, HotelRepository>();

        services.AddDbContext<HotelDbContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("HotelDatabase"));

            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        });


        services.AddMediatR(config => config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        services.AddTransient<HotelValidator>();


        var mappingConfig = new MapperConfiguration(cfg => { cfg.AddProfile(new MappingProfile()); });

        IMapper mapper = mappingConfig.CreateMapper();

        services.AddSingleton(mapper);

        services.AddOpenTelemetryExtension(Configuration);

        services.AddRateLimiter(options =>
        {
            options.AddPolicy<string, DefaultRateLimiterPolicy>(RateLimiterPolicyNames.DefaultPolicy);
        });

        return services;
    }

    public static void MigrateReservationDb(this IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
        var dbContext = serviceScope.ServiceProvider.GetRequiredService<HotelDbContext>();

        dbContext.Database.Migrate();
    }
}
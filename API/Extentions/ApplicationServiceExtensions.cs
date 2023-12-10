﻿using API.Data;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Extenstions;

public static class ApplicationServiceExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddDbContext<DataContext>(opt => 
        {
            opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
        });
        services.AddCors();
        services.AddScoped<ITokenServices,TokenService>();

        return services;
    }
}

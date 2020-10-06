using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Application.Interfaces;
using TaskManager.Infra.Context;

namespace TaskManager.Infra.DependencyInjection
{
    public static class InfraExtention
    {
        public static IServiceCollection InfraRegister(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<DatabaseContext>(e => e.UseMySql(configuration.GetConnectionString("sql")));
            services.AddTransient<IDatabaseContext, DatabaseContext>();
            return services;
        }
    }
}

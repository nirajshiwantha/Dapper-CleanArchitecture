using Microsoft.Extensions.DependencyInjection;
using DapperExample.Application.Abstractions;
using DapperExample.Application.Persistance;
using DapperExample.Infrastructure.Persistance;
using DapperExample.Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace DapperExample.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<ISqlConnectionFactory, SqlConnectionFactory>();
            return services;
        }
    }


    ////////////////////////////////////////////////////////////////////////////////
    /////  Uncomment below and comment above section when you use with EF core /////
    ////////////////////////////////////////////////////////////////////////////////
    
    //public static IServiceCollection AddInfrastructure(
    //this IServiceCollection services,
    //ConfigurationManager configuration)
    //{
    //    services.AddDbContext<DapperexampleDbContext>(
    //        opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")
    //        , b => b.MigrationsAssembly("Dapperexample.API")));
    //    services.AddScoped<IProductRepository, ProductRepository>();
    //    services.AddScoped<ISqlConnectionFactory, SqlConnectionFactory>();
    //    return services;
    //}
}

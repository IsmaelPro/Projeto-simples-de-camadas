using Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.Repository;

namespace Projeto_simples_de_camadas.Extensions.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            //App DbContext
            services.AddDbContext<ProductContext>(options =>
                          options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")
                              , x => x.MigrationsAssembly(typeof(ProductContext).Assembly.FullName)
                          ).EnableSensitiveDataLogging()
                      );

            return services;
        }
    }
}
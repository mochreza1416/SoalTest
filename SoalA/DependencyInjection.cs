using SoalA.Context;
using SoalA.Service;

namespace SoalA
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            // Service
            services.AddScoped<IProdukService, ProdukService>();
            services.AddDbContext<DatabaseContext>();
            return services;
        }
    }
}

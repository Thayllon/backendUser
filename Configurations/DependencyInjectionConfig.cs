using Microsoft.Extensions.DependencyInjection;
using Backend.Data.Context;
using Backend.Data.Repositories;
using Backend.Domain.Interfaces;

namespace Backend.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<AppDbContext>();
        }
    }
}

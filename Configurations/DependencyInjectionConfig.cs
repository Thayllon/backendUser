using Microsoft.Extensions.DependencyInjection;
using Backend.Data.Context;
using Backend.Data.Repositories;
using Backend.Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Backend.Applications.Queries;
using Backend.Applications.CommandHandlers;
using Backend.Applications.Commands;
using MediatR;

namespace Backend.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            //services.AddScoped<IRequestHandler<AdicionarUsuarioCommand>, UsuarioCommandHandler>();
            //services.AddScoped<IRequestHandler<AtualizarUsuarioCommand>, UsuarioCommandHandler>();
            //services.AddScoped<IRequestHandler<RemoverUsuarioCommand>, UsuarioCommandHandler>();

            services.AddScoped<IUsuarioQueries, UsuarioQueries>();

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<AppDbContext>();
        }
    }
}

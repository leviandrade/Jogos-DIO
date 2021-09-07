using Microsoft.Extensions.DependencyInjection;
using Jogos.DIO.Domain.Interfaces.Services;
using Jogos.DIO.Service.Services;

namespace Jogos.DIO.Infra.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IJogoService, JogoService>();
        }
    }
}

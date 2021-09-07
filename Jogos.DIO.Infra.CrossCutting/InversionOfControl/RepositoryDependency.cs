using Microsoft.Extensions.DependencyInjection;
using Jogos.DIO.Domain.Interfaces;
using Jogos.DIO.Domain.Interfaces.Repositories;
using Jogos.DIO.Infra.Data.Context;
using Jogos.DIO.Infra.Data.Repository;

namespace Jogos.DIO.Infra.CrossCutting.InversionOfControl
{
    public static class RepositoryDependency
    {
        public static void AddRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork<JogoContext>, UnitOfWork<JogoContext>>();
            services.AddScoped<IJogoRepository, JogoRepository>();
        }
    }
}

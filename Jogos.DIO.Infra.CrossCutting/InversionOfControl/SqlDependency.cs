using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Jogos.DIO.Infra.Data.Context;

namespace Jogos.DIO.Infra.CrossCutting.InversionOfControl
{
    public static class SqlDependency
    {
        public static void AddSqlDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JogoContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("Jogo")), ServiceLifetime.Scoped);

        }
    }
}

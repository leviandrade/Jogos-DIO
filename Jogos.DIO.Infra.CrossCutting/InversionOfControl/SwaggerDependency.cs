using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Jogos.DIO.Infra.CrossCutting.InversionOfControl
{
    public static class SwaggerDependency
    {
        public static void AddSwaggerDependency(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Jogos API",
                        Version = "v1",
                        Description = "API REST criada bara o Bootcamp da Digital Innovation One",
                    });
            });
        }

        public static void UseSwaggerDependency(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Jogo API");
                c.DocumentTitle = "Jogo API";
                c.DocExpansion(DocExpansion.List);
            });
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCivil.Usuario.Infra.Swagger
{
    public static class SwaggerBootstrapper
    {
        public static void RegisterSwaggerGenerator(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
                options.SwaggerDoc("v1",
                                    new OpenApiInfo
                                    {
                                        Title = "Usuários",
                                        Version = "v1"
                                    }
                ));

            services.ConfigureSwaggerGen(options =>
            {
                options.CustomSchemaIds(type => type.FullName);
            });
        }

        public static void UseSwaggerGenerator(this IApplicationBuilder app)
        {
            app.UseSwagger(options =>
            {
                options.RouteTemplate = $"agrocivil-back-usuario/swagger/{{documentName}}/swagger.json";
            });

            app.UseSwaggerUI(options =>
            {
                options.RoutePrefix = "agrocivil-back-usuario/swagger";
                options.SwaggerEndpoint($"/agrocivil-back-usuario/swagger/v1/swagger.json", "AgroCivil");
             });
        }
    }
}

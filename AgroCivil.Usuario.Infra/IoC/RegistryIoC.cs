using AgroCivil.Usuario.Domain.Services.IUserService;
using AgroCivil.Usuario.Infra.Services;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCivil.Usuario.Infra.IoC
{
    [ExcludeFromCodeCoverage]
    public static class RegistryIoC
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            //SERVICES
            services.AddTransient<IUserService, UserService>();

            //MEDIATR CONFIG
            var assembly = AppDomain.CurrentDomain.Load("AgroCivil.Usuario.Domain");
            services.AddMediatR(assembly);
        }
    }
}

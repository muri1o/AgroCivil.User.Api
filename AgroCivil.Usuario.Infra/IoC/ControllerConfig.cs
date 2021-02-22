using AgroCivil.Usuario.Domain.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroCivil.Usuario.Infra.IoC
{
    public static class ControllerConfig
    {
        public static IServiceCollection AddControllerConfig(this IServiceCollection services)
        {
            services.AddControllers()
                     .ConfigureApiBehaviorOptions(options =>
                     {
                         options.SuppressMapClientErrors = true;
                         options.InvalidModelStateResponseFactory = actionContext =>
                         {
                             return new BadRequestObjectResult(RenderErrorsFromModelState(actionContext.ModelState));
                         };
                     });

            return services;
        }

        public static Error4xxModel RenderErrorsFromModelState(ModelStateDictionary modelState)
        {
            var objError = new Error4xxModel();
            var lstFields = new List<Error4xxFieldModel>();

            foreach (KeyValuePair<string, ModelStateEntry> field in modelState)
            {
                if (field.Value.Errors.Count > 0)
                {
                    var fieldModel = new Error4xxFieldModel
                    {
                        Name = field.Key,
                        Details = field.Value.Errors.Select(Error => Error.ErrorMessage).ToList()
                    };
                    lstFields.Add(fieldModel);
                }
            }

            objError.Code = "400";
            objError.Message = "Campos inválidos";
            objError.Details = null;
            objError.Fields = lstFields;

            return objError;
        }
    }
}

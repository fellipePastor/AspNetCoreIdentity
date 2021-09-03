using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Config
{
    public static class DependencyInjectionConfig
    {

        public static IServiceCollection AddAuthorizationConfig(this IServiceCollection services) 
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("PodeExcluir", policy => policy.RequireClaim("PodeExcluir"));

            });


            return services;
        }

    }
}

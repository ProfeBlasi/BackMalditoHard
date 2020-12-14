using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WSS.MalditoHard.Bootstrap.Providers;

namespace WSS.MalditoHard.Bootstrap
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSwagger();
            services.AddMalditoApiVersioning();
            return services;
        }

    }
}


using ManageClients.Service.Impl;
using ManageClients.Service.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ManageClients.Service
{
    public static class DependencyInjection
    {
        public static void AddServiceLayer(this IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}

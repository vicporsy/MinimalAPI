using MinimalAPI.Core.Service;
using MinimalAPI.Service;
using MinimalAPI.Service.Interface;

namespace MinimalAPI.ServiceInitializer
{
    public static class AddServices
    {
        public static void AddServiceConfiguration(this IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();
        }
    }
}

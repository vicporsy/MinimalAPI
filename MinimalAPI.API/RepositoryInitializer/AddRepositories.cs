using MinimalAPI.Core.Repository.Interface;
using MinimalAPI.Infra.Contexts;
using MinimalAPI.Repository;

namespace MinimalAPI.RepositoryInitializer
{
    public static class AddRepositories
    {
        public static void AddRepositoryConfiguration(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
            services.AddScoped<IClientRepository, ClientRepository>();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MinimalAPI.Configuration;
using MinimalAPI.Infra.Entities;

namespace MinimalAPI.Infra.Contexts
{
    public class AppDbContext : DbContext
    {
        #region .: Constructor :.   
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        #endregion

        #region .: Model Creating :.
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ClientConfiguration());
        }

        #endregion

        #region .: Db Sets :.
        public DbSet<Client> Clientes { get; set; }
#endregion
    }
}

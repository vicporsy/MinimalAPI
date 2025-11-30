using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MinimalAPI.Infra.Entities;

namespace MinimalAPI.Configuration
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {

        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .ToTable("Clientes");

            builder
                .HasKey(k => k.Id)
                .IsClustered();

            builder
                .Property(p => p.Name)
                .HasMaxLength(200);

            builder
                .Property(p => p.Document)
                .HasMaxLength(20);

            builder
                .Property(p => p.Email)
                .HasMaxLength(100);

            builder
                .Property(p => p.Telefone)
                .HasMaxLength(20);

            builder.HasIndex(s => new { s.Guid });
            builder.HasIndex(s => new { s.Document });
            builder.HasIndex(s => new { s.Email });
            builder.HasIndex(s => new { s.Telefone });
            builder.HasIndex(s => new { s.Name }).IncludeProperties(s => new {s.Document, s.Email, s.Telefone, s.Guid});
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoDeVendasComCQRS.Domain.Entidades;

namespace ProjetoDeVendasComCQRS.Infra.Context.TypeConfigurations
{
    public class ClienteTypeConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Nome).IsRequired().HasMaxLength(100);
            builder.Property(q => q.Cpf).IsRequired().HasMaxLength(11);
            builder.Property(q => q.Email).IsRequired().HasMaxLength(50);
        }
    }
}

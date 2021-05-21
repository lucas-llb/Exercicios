using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoDeVendasComCQRS.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDeVendasComCQRS.Infra.Context.TypeConfigurations
{
    public class ProdutoTypeConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Nome).IsRequired().HasMaxLength(50);
            builder.Property(q => q.Preco).IsRequired();
        }
    }
}

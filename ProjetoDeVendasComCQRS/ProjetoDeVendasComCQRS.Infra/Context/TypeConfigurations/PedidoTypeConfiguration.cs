using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoDeVendasComCQRS.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDeVendasComCQRS.Infra.Context.TypeConfigurations
{
    public class PedidoTypeConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Data).IsRequired();
            builder.Property(q => q.Quantidade).IsRequired();
            builder.Property(q => q.ValorTotal).IsRequired();
            builder.HasOne(q => q.Cliente).WithMany().HasForeignKey(q => q.ClienteId);
            builder.HasOne(q => q.Produto).WithMany().HasForeignKey(q => q.ProdutoId);
        }
    }
}

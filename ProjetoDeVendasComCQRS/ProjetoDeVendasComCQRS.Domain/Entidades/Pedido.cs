using System;

namespace ProjetoDeVendasComCQRS.Domain.Entidades
{
    public class Pedido : BaseEntity
    {
        public Guid ProdutoId { get; set; }
        public virtual Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }
        public DateTime Data { get; set; }
        public Guid ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }

        public Pedido()
        {
        }
    }
}

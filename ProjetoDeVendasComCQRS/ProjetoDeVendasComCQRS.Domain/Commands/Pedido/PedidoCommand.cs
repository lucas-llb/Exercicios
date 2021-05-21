using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoDeVendasComCQRS.Domain.Commands.Pedido
{
    public class PedidoCommand : CommandBase
    {
        public Guid Id { get; protected set; }
        public Guid ProdutoId { get; protected set; }
        public int Quantidade { get; protected set; }
        public double ValorTotal { get; protected set; }
        public DateTime Data { get; protected set; }
        public Guid ClienteId { get; protected set; }

    }
}

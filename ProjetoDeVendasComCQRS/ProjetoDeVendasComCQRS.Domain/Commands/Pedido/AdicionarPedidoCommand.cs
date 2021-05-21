using System;

namespace ProjetoDeVendasComCQRS.Domain.Commands.Pedido
{
    public class AdicionarPedidoCommand : PedidoCommand
    {
        public AdicionarPedidoCommand(int quantidade, double valorTotal, DateTime data, Guid produtoId, Guid clienteId)
        {
            Quantidade = quantidade;
            ValorTotal = valorTotal;
            Data = data;
            ProdutoId = produtoId;
            ClienteId = clienteId;
        }
    }
}

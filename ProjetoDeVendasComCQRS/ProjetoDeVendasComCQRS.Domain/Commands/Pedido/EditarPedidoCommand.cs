using System;

namespace ProjetoDeVendasComCQRS.Domain.Commands.Pedido
{
    public class EditarPedidoCommand : PedidoCommand
    {
        public EditarPedidoCommand(Guid id, int quantidade, double valorTotal, DateTime data, Guid produtoId, Guid clienteId)
        {
            Id = id;
            Quantidade = quantidade;
            ValorTotal = valorTotal;
            Data = data;
            ProdutoId = produtoId;
            ClienteId = clienteId;
        }
    }
}

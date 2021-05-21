using ProjetoDeVendasComCQRS.Domain.Commands.Pedido;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;

namespace ProjetoDeVendasComCQRS.Domain.Validation.Pedido
{
    public class RemoverPedidoCommandValidator : PedidoCommandValidator<RemoverPedidoCommand>
    {
        public RemoverPedidoCommandValidator(IProdutoRepository produtoRepository, IClienteRepository clienteRepository, IPedidoRepository pedidoRepository)
            : base(produtoRepository, clienteRepository, pedidoRepository)
        {
            VerificarSePedidoExiste();
        }
    }
}

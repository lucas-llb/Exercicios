using ProjetoDeVendasComCQRS.Domain.Commands.Pedido;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;

namespace ProjetoDeVendasComCQRS.Domain.Validation.Pedido
{
    public class EditarPedidoCommandValidator : PedidoCommandValidator<EditarPedidoCommand>
    {
        public EditarPedidoCommandValidator(IProdutoRepository produtoRepository, IClienteRepository clienteRepository, IPedidoRepository pedidoRepository)
            : base(produtoRepository, clienteRepository, pedidoRepository)
        {
            VerificarSePedidoExiste();
            ValidarCliente();
            ValidarProduto();
            ValidarQuantidade();
            VerificarSeClienteExiste();
            VerificarSeProdutoExiste();
        }
    }
}

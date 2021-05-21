using ProjetoDeVendasComCQRS.Domain.Commands.Pedido;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;

namespace ProjetoDeVendasComCQRS.Domain.Validation.Pedido
{
    public class AdicionarPedidoCommandValidator : PedidoCommandValidator<AdicionarPedidoCommand>
    {
        public AdicionarPedidoCommandValidator(IClienteRepository clienteRepository, IProdutoRepository produtoRepository, IPedidoRepository pedidoRepository)
            : base(produtoRepository, clienteRepository, pedidoRepository)
        {
            ValidarCliente();
            ValidarProduto();
            ValidarQuantidade();
            VerificarSeClienteExiste();
            VerificarSeProdutoExiste();
        }
    }
}

using FluentValidation;
using ProjetoDeVendasComCQRS.Domain.Commands.Pedido;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;

namespace ProjetoDeVendasComCQRS.Domain.Validation.Pedido
{
    public abstract class PedidoCommandValidator<T> : AbstractValidator<T> where T : PedidoCommand
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IPedidoRepository _pedidoRepository;

        protected PedidoCommandValidator(IProdutoRepository produtoRepository, IClienteRepository clienteRepository, IPedidoRepository pedidoRepository)
        {
            _produtoRepository = produtoRepository;
            _clienteRepository = clienteRepository;
            _pedidoRepository = pedidoRepository;
        }

        protected void ValidarQuantidade()
        {
            RuleFor(q => q.Quantidade)
                .NotEmpty().WithMessage("O campo quantidade é obrigatório!")
                .IsValidInteger().WithMessage("A quantidade deve ser maior que 0!");
        }
        protected void ValidarProduto()
        {
            RuleFor(q => q.ProdutoId)
                .NotEmpty().WithMessage("É obrigatório informar um produto!");
        }
        protected void ValidarCliente()
        {
            RuleFor(q => q.ClienteId)
                .NotEmpty().WithMessage("O Campo cliente é obrigatório!");
        }
        protected void VerificarSeClienteExiste()
        {
            RuleFor(q => q.ClienteId)
                .Must((id) =>
                {
                    return _clienteRepository.VerificaSeIdExiste(id);
                }).WithMessage("Cliente não encontrado!")
                .WithSeverity(Severity.Error);
        }
        protected void VerificarSeProdutoExiste()
        {
            RuleFor(q => q.ProdutoId)
                .Must((id) =>
                {
                    return _produtoRepository.VerificarSeIdExiste(id);
                }).WithMessage("Produto não encontrado!")
                .WithSeverity(Severity.Error);
        }
        protected void VerificarSePedidoExiste()
        {
            RuleFor(q => q.Id)
                .Must((id) =>
                {
                    return _pedidoRepository.VerificarSePedidoExiste(id);
                }).WithMessage("Pedido não encontrado!")
                .WithSeverity(Severity.Error);
        }
    }
}

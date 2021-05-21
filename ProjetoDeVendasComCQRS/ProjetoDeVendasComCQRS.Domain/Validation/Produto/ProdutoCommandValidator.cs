using FluentValidation;
using ProjetoDeVendasComCQRS.Domain.Commands.Produto;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;

namespace ProjetoDeVendasComCQRS.Domain.Validation.Produto
{
    public abstract class ProdutoCommandValidator<T> : AbstractValidator<T> where T : ProdutoCommand
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoCommandValidator(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        protected void ValidarNome()
        {
            RuleFor(q => q.Nome)
                .NotEmpty().WithMessage("O nome do produto é obrigatório!")
                .Length(2, 50).WithMessage("O nome do produto deve conter entre 2 e 50 caracteres!");
        }

        protected void ValidarPreco()
        {
            RuleFor(q => q.Preco)
                .NotEmpty().WithMessage("O campo preço é obrigatório!")
                .IsValidPrice().WithMessage("O campo preço não apresenta formato válido!");
        }

        protected void ValidarNomeExiste()
        {
            RuleFor(q => q.Nome)
                .Must((nome) =>
                {
                    return !_produtoRepository.VarificarSeProdutoExiste(nome);
                }).WithMessage("Esse produto já está cadastrado!")
                .WithSeverity(Severity.Error);
        }
        protected void ValidarIdExiste()
        {
            RuleFor(q => q.Id)
                .Must((id) =>
                {
                    return _produtoRepository.VerificarSeIdExiste(id);
                }).WithMessage("Produto não encontrado!")
                .WithSeverity(Severity.Error);
        }
    }
}

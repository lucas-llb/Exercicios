using ProjetoDeVendasComCQRS.Domain.Commands.Produto;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;

namespace ProjetoDeVendasComCQRS.Domain.Validation.Produto
{
    public class AdicionarProdutoCommandValidator : ProdutoCommandValidator<AdicionarProdutoCommand>
    {
        public AdicionarProdutoCommandValidator(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            ValidarNome();
            ValidarNomeExiste();
            ValidarPreco();
        }
    }
}

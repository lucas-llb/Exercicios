using ProjetoDeVendasComCQRS.Domain.Commands.Produto;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;

namespace ProjetoDeVendasComCQRS.Domain.Validation.Produto
{
    public class RemoverProdutoCommandValidator : ProdutoCommandValidator<RemoverProdutoCommand>
    {
        public RemoverProdutoCommandValidator(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            ValidarIdExiste();
        }
    }
}

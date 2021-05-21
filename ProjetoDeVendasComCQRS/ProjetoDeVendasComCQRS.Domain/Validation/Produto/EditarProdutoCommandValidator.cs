using ProjetoDeVendasComCQRS.Domain.Commands.Produto;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;

namespace ProjetoDeVendasComCQRS.Domain.Validation.Produto
{
    public class EditarProdutoCommandValidator : ProdutoCommandValidator<EditarProdutoCommand>
    {
        public EditarProdutoCommandValidator(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            ValidarIdExiste();
            ValidarNome();
            ValidarNomeExiste();
            ValidarPreco();
        }
    }
}

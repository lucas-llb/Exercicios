using ProjetoDeVendasComCQRS.Domain;
using ProjetoDeVendasComCQRS.Domain.Commands.Produto;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Application.Interfaces.Mappers
{
    public interface IProdutoMapper
    {
        Produto ConverterAdicionar(AdicionarProdutoCommand command);
        Task<Produto> ConverterEditar(EditarProdutoCommand command);
    }
}

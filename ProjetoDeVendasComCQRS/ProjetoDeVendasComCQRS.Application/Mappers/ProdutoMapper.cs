using ProjetoDeVendasComCQRS.Application.Interfaces.Mappers;
using ProjetoDeVendasComCQRS.Domain;
using ProjetoDeVendasComCQRS.Domain.Commands.Produto;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Application.Mappers
{
    public class ProdutoMapper : IProdutoMapper
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoMapper(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto ConverterAdicionar(AdicionarProdutoCommand command)
        {
            return new Produto()
            {
                Nome = command.Nome,
                Preco = command.Preco
            };
        }

        public async Task<Produto> ConverterEditar(EditarProdutoCommand command)
        {
            var entidade = await _produtoRepository.GetByIdAsync(command.Id);
            entidade.Nome = command.Nome;
            entidade.Preco = command.Preco;
            return entidade;
        }
    }
}

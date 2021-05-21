using ProjetoDeVendasComCQRS.Domain;
using ProjetoDeVendasComCQRS.Domain.Commands.Produto;
using ProjetoDeVendasComCQRS.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Application.Interfaces.Services
{
    public interface IProdutoService
    {
        Task<ResponseToUser> CreateAsync(AdicionarProdutoCommand command);
        Task<ResponseToUser> UpdateAsync(EditarProdutoCommand command);
        Task<ResponseToUser> RemoveAsync(RemoverProdutoCommand command);
        Task<IEnumerable<Produto>> GetAllAsync();
    }
}

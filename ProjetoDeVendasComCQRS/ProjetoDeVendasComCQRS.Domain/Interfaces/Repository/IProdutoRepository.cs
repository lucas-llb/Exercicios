using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Domain.Interfaces.Repository
{
    public interface IProdutoRepository
    {
        Task<Produto> GetByIdAsync(Guid id);
        Task<IEnumerable<Produto>> GetAllAsync();
        Task CreateAsync(Produto entity);
        Task UpdateAsync(Produto entity);
        Task DeleteAsync(Guid id);
        bool VarificarSeProdutoExiste(string nome);
        bool VerificarSeIdExiste(Guid id);
    }
}

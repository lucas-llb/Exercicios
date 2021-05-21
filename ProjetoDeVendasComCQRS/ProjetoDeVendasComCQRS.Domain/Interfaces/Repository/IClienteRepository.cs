using ProjetoDeVendasComCQRS.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Domain.Interfaces.Repository
{
    public interface IClienteRepository
    {
        Task<Cliente> GetByIdAsync(Guid id);
        Task<IEnumerable<Cliente>> GetAllAsync();
        Task CreateAsync(Cliente entity);
        Task UpdateAsync(Cliente entity);
        Task DeleteAsync(Guid id);
        bool VerificaSeJaExisteCpf(string cpf);
        bool VerificaSeIdExiste(Guid id);
    }
}

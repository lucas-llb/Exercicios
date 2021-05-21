using ProjetoDeVendasComCQRS.Domain.Commands.Cliente;
using ProjetoDeVendasComCQRS.Domain.Entidades;
using ProjetoDeVendasComCQRS.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Application.Interfaces.Services
{
    public interface IClienteService
    {
        Task<ResponseToUser> CreateAsync(AdicionarClienteCommand command);
        Task<ResponseToUser> UpdateAsync(EditarClienteCommand command);
        Task<ResponseToUser> RemoveAsync(RemoverClienteCommand command);
        Task<IEnumerable<Cliente>> GetAllAsync();
    }
}

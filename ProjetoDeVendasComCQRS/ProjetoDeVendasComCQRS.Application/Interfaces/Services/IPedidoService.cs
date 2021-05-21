using ProjetoDeVendasComCQRS.Domain.Commands.Pedido;
using ProjetoDeVendasComCQRS.Domain.Entidades;
using ProjetoDeVendasComCQRS.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Application.Interfaces.Services
{
    public interface IPedidoService
    {
        Task<ResponseToUser> CreateAsync(AdicionarPedidoCommand command);
        Task<ResponseToUser> UpdateAsync(EditarPedidoCommand command);
        Task<ResponseToUser> RemoveAsync(RemoverPedidoCommand command);
        Task<IEnumerable<Pedido>> GetAllAsync();
    }
}

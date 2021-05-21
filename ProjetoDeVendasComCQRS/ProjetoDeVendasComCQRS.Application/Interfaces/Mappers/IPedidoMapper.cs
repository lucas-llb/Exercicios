using ProjetoDeVendasComCQRS.Domain.Commands.Pedido;
using ProjetoDeVendasComCQRS.Domain.Entidades;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Application.Interfaces.Mappers
{
    public interface IPedidoMapper
    {
        Task<Pedido> ConverterAdicionar(AdicionarPedidoCommand command);
        Task<Pedido> ConverterEditar(EditarPedidoCommand command);
    }
}

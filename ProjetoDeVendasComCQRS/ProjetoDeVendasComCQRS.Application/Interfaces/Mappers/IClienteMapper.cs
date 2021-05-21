using ProjetoDeVendasComCQRS.Domain.Commands.Cliente;
using ProjetoDeVendasComCQRS.Domain.Entidades;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Application.Interfaces.Mappers
{
    public interface IClienteMapper
    {
        Cliente ConverterAdicionar(AdicionarClienteCommand command);
        Task<Cliente> ConverterEditar(EditarClienteCommand command);
    }
}

using FluentValidation;
using ProjetoDeVendasComCQRS.Application.Interfaces.Mappers;
using ProjetoDeVendasComCQRS.Application.Interfaces.Services;
using ProjetoDeVendasComCQRS.Domain.Commands.Pedido;
using ProjetoDeVendasComCQRS.Domain.Entidades;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;
using ProjetoDeVendasComCQRS.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Application.Services
{
    public class PedidoService : BaseServices, IPedidoService
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IValidator<AdicionarPedidoCommand> _adicionarValidator;
        private readonly IValidator<EditarPedidoCommand> _editarValidator;
        private readonly IValidator<RemoverPedidoCommand> _removerValidator;
        private readonly IPedidoMapper _pedidoMapper;
        public PedidoService(
            IPedidoRepository pedidoRepository,
            IValidator<AdicionarPedidoCommand> adicionarValidator,
            IValidator<EditarPedidoCommand> editarValidator,
            IValidator<RemoverPedidoCommand> removerValidator,
            IPedidoMapper pedidoMapper)
        {
            _pedidoRepository = pedidoRepository;
            _adicionarValidator = adicionarValidator;
            _editarValidator = editarValidator;
            _removerValidator = removerValidator;
            _pedidoMapper = pedidoMapper;
        }

        public async Task<ResponseToUser> CreateAsync(AdicionarPedidoCommand command)
        {
            var result = _adicionarValidator.Validate(command);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            var entidade = await _pedidoMapper.ConverterAdicionar(command);
            await _pedidoRepository.CreateAsync(entidade);
            return SuccessResult();
        }

        public async Task<ResponseToUser> UpdateAsync(EditarPedidoCommand command)
        {
            var result = _editarValidator.Validate(command);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            var entidade = await _pedidoMapper.ConverterEditar(command);
            await _pedidoRepository.UpdateAsync(entidade);
            return SuccessResult();
        }

        public async Task<ResponseToUser> RemoveAsync(RemoverPedidoCommand command)
        {
            var result = _removerValidator.Validate(command);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            await _pedidoRepository.DeleteAsync(command.Id);
            return SuccessResult();
        }

        public async Task<IEnumerable<Pedido>> GetAllAsync()
        {
            return await _pedidoRepository.GetAllAsync();
        }

    }
}

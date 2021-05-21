using FluentValidation;
using ProjetoDeVendasComCQRS.Application.Interfaces.Mappers;
using ProjetoDeVendasComCQRS.Application.Interfaces.Services;
using ProjetoDeVendasComCQRS.Domain.Commands.Cliente;
using ProjetoDeVendasComCQRS.Domain.Entidades;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;
using ProjetoDeVendasComCQRS.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Application.Services
{
    public class ClienteService : BaseServices, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IValidator<AdicionarClienteCommand> _adicionarValidator;
        private readonly IValidator<EditarClienteCommand> _editarValidator;
        private readonly IValidator<RemoverClienteCommand> _removerValidator;
        private readonly IClienteMapper _clienteMapper;
        public ClienteService(IClienteRepository clienteRepository,
            IValidator<AdicionarClienteCommand> adicionarValidator,
            IValidator<EditarClienteCommand> editarValidator,
            IValidator<RemoverClienteCommand> removerValidator,
            IClienteMapper clienteMapper)
        {
            _clienteRepository = clienteRepository;
            _adicionarValidator = adicionarValidator;
            _editarValidator = editarValidator;
            _removerValidator = removerValidator;
            _clienteMapper = clienteMapper;
        }

        public async Task<ResponseToUser> CreateAsync(AdicionarClienteCommand command)
        {
            var result = _adicionarValidator.Validate(command);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            var entidade = _clienteMapper.ConverterAdicionar(command);
            await _clienteRepository.CreateAsync(entidade);
            return SuccessResult();
        }

        public async Task<ResponseToUser> UpdateAsync(EditarClienteCommand command)
        {
            var result = _editarValidator.Validate(command);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            var entidade = await _clienteMapper.ConverterEditar(command);
            await _clienteRepository.UpdateAsync(entidade);
            return SuccessResult();
        }
        public async Task<ResponseToUser> RemoveAsync(RemoverClienteCommand command)
        {
            var result = _removerValidator.Validate(command);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            await _clienteRepository.DeleteAsync(command.Id);
            return SuccessResult();
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _clienteRepository.GetAllAsync();
        }
    }
}

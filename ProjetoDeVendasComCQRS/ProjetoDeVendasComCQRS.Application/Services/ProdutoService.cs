using FluentValidation;
using ProjetoDeVendasComCQRS.Application.Interfaces.Mappers;
using ProjetoDeVendasComCQRS.Application.Interfaces.Services;
using ProjetoDeVendasComCQRS.Domain;
using ProjetoDeVendasComCQRS.Domain.Commands.Produto;
using ProjetoDeVendasComCQRS.Domain.Interfaces.Repository;
using ProjetoDeVendasComCQRS.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Application.Services
{
    public class ProdutoService : BaseServices, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IValidator<AdicionarProdutoCommand> _adicionarValidator;
        private readonly IValidator<EditarProdutoCommand> _editarValidator;
        private readonly IValidator<RemoverProdutoCommand> _removerValidator;
        private readonly IProdutoMapper _produtoMapper;
        public ProdutoService(IProdutoRepository produtoRepository,
                              IValidator<AdicionarProdutoCommand> adicionarValidator,
                              IValidator<EditarProdutoCommand> editarValidator,
                              IValidator<RemoverProdutoCommand> removerValidator,
                              IProdutoMapper produtoMapper)
        {
            _produtoRepository = produtoRepository;
            _adicionarValidator = adicionarValidator;
            _editarValidator = editarValidator;
            _removerValidator = removerValidator;
            _produtoMapper = produtoMapper;
        }

        public async Task<ResponseToUser> CreateAsync(AdicionarProdutoCommand command)
        {
            var result = _adicionarValidator.Validate(command);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            var entidade = _produtoMapper.ConverterAdicionar(command);
            await _produtoRepository.CreateAsync(entidade);
            return SuccessResult();
        }

        public async Task<ResponseToUser> UpdateAsync(EditarProdutoCommand command)
        {
            var result = _editarValidator.Validate(command);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            var entidade = await _produtoMapper.ConverterEditar(command);
            await _produtoRepository.UpdateAsync(entidade);
            return SuccessResult();
        }
        public async Task<ResponseToUser> RemoveAsync(RemoverProdutoCommand command)
        {
            var result = _removerValidator.Validate(command);
            if (!result.IsValid)
            {
                return ErrorResult(result.Errors.Select(q => q.ErrorMessage));
            }
            await _produtoRepository.DeleteAsync(command.Id);
            return SuccessResult();
        }

        public async Task<IEnumerable<Produto>> GetAllAsync()
        {
            return await _produtoRepository.GetAllAsync();
        }
    }
}

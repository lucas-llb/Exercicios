using Microsoft.AspNetCore.Mvc;
using ProjetoDeVendasComCQRS.Application.Interfaces.Services;
using ProjetoDeVendasComCQRS.Domain.Commands.Produto;
using System;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> Post(AdicionarProdutoCommand command)
        {
            var result = await _produtoService.CreateAsync(command);
            if (result.Success)
            {
                return Ok("Produto cadastrado com sucesso!");
            }
            else
            {
                return BadRequest(result.Messages);
            }
        }

        [HttpPut]
        [Route("editar")]
        public async Task<IActionResult> Put(EditarProdutoCommand command)
        {
            var result = await _produtoService.UpdateAsync(command);
            if (result.Success)
            {
                return Ok("Produto alterado com sucesso!");
            }
            else
            {
                return BadRequest(result.Messages);
            }
        }

        [HttpDelete]
        [Route("remover")]
        public async Task<IActionResult> Delete(RemoverProdutoCommand command)
        {
            var result = await _produtoService.RemoveAsync(command);
            if (result.Success)
            {
                return Ok("Produto deletado com sucesso!");
            }
            else
            {
                return BadRequest(result.Messages);
            }

        }

        [HttpGet]
        [Route("listar")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _produtoService.GetAllAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

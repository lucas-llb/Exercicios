using Microsoft.AspNetCore.Mvc;
using ProjetoDeVendasComCQRS.Application.Interfaces.Services;
using ProjetoDeVendasComCQRS.Domain.Commands.Cliente;
using System;
using System.Threading.Tasks;

namespace ProjetoDeVendasComCQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> Post(AdicionarClienteCommand command)
        {
            var result = await _clienteService.CreateAsync(command);
            if (result.Success)
            {
                return Ok("Cliente cadastrado com sucesso");
            }
            else
                return BadRequest(result.Messages);
        }
        [HttpPut]
        [Route("editar")]
        public async Task<IActionResult> Put(EditarClienteCommand command)
        {
            var result = await _clienteService.UpdateAsync(command);
            if (result.Success)
                return Ok("Cliente editado com sucesso");
            else
                return BadRequest(result.Messages);
        }
        [HttpDelete]
        [Route("remover")]
        public async Task<IActionResult> Delete(RemoverClienteCommand command)
        {
            var result = await _clienteService.RemoveAsync(command);
            if (result.Success)
                return Ok("Cliente deletado com sucesso");
            else
                return BadRequest(result.Messages);
        }
        [HttpGet]
        [Route("listar")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _clienteService.GetAllAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

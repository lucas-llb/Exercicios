using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PadawanApplication.Interfaces;
using ProjetoPadawan.Models;

namespace ProjetoPadawan.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _alunoService.GetAllAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> Post(Alunos aluno)
        {
            var result = await _alunoService.CreateAsync(aluno);
            if (result.Success)
            {
                return Ok("Cadastro realizado com sucesso!");
            }
            else
            {
                return BadRequest(result.Messages);
            }
        }

        [HttpDelete]
        [Route("deletar")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _alunoService.DeleteAsync(id);
            if (result.Success)
            {
                return Ok("Aluno deletado com sucesso!");
            }
            else
            {
                return BadRequest(result.Messages);
            }
        }
    }
}

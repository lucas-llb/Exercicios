using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PadawanApplication.Interfaces;
using ProjetoPadawan.Models;

namespace ProjetoPadawan.Controllers
{
    [ApiController]
    [Route("AlunoController")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        [Route("listaraluno")]
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
        [Route("cadastraraluno")]
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
        [Route("deletaraluno")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _alunoService.DeleteAsync(id);
            if (result.Success)
            {
                return Ok("Categoria deletada com sucesso!");
            }
            else
            {
                return BadRequest(result.Messages);
            }
        }
    }
}

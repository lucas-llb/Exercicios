using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PadawanApplication.Interfaces;
using ProjetoPadawan.Models;

namespace ProjetoPadawan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly ICursoService _cursoService;

        public CursoController(ICursoService cursoService)
        {
            _cursoService = cursoService;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _cursoService.GetAllAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> Post(Cursos curso)
        {
            var result = await _cursoService.CreateAsync(curso);
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
        [Route("deletarcurso")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _cursoService.DeleteAsync(id);
            if (result.Success)
            {
                return Ok("Curso deletado com sucesso!");
            }
            else
            {
                return BadRequest(result.Messages);
            }
        }
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PadawanApplication.Interfaces;
using ProjetoPadawan.Models;

namespace ProjetoPadawan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private readonly IMateriaService _materiaService;

        public MateriasController(IMateriaService materiaService)
        {
            _materiaService = materiaService;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _materiaService.GetAllAsync());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("cadastrar")]
        public async Task<IActionResult> Post(Materias materia)
        {
            var result = await _materiaService.CreateAsync(materia);
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
            var result = await _materiaService.DeleteAsync(id);
            if (result.Success)
            {
                return Ok("Materia deletada com sucesso!");
            }
            else
            {
                return BadRequest(result.Messages);
            }
        }
    }
}

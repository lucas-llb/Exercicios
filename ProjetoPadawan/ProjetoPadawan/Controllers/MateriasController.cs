using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoPadawan.Models;
using ProjetoPadawan.Tools;

namespace ProjetoPadawan.Controllers
{
    [Route("MateriaController")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        [HttpGet]
        [Route("listarmaterias")]
        public ActionResult Get()
        {
            var materia = new List<Materias>();
            var gravarmateria = new GravarMaterias();
            materia = gravarmateria.Result();
            return Ok(materia);
        }

        [HttpPost]
        [Route("cadastrarmateria")]
        public ActionResult Post(Materias materia)
        {
            var gravarmateria = new GravarMaterias();
            gravarmateria.Add(materia);
            return Ok(materia);
        }

        [HttpDelete]
        [Route("deletarmateria")]
        public ActionResult Delete(int id)
        {
            var gravarmateria = new GravarMaterias();
            gravarmateria.Deletar(id);
            return Ok("Materia removida do sistema.");
        }
    }
}

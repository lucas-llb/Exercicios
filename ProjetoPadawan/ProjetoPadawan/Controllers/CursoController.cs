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
    [Route("CursoController")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        [HttpGet]
        [Route("listarcurso")]
        public ActionResult Get()
        {
            var cursos = new List<Cursos>();
            var gravarcursos = new GravarCursos();
            cursos = gravarcursos.Result();
            return Ok(cursos);

        }

        [HttpPost]
        [Route("cadastrarcurso")]
        public ActionResult Post(Cursos curso)
        {
            var gravarcurso = new GravarCursos();
            gravarcurso.Add(curso);
            return Ok(curso);
        }
        [HttpDelete]
        [Route("deletarcurso")]
        public ActionResult Delete(int id)
        {
            var gravarcurso = new GravarCursos();
            gravarcurso.Deletar(id);
            return Ok("Curso removido do sistema.");
        }
    }
}

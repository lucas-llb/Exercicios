using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetoPadawan.Data;
using ProjetoPadawan.Models;

namespace ProjetoPadawan.Controllers
{
    [Route("CursoController")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly AlunoContext db = new AlunoContext(); 
        [HttpGet]
        [Route("listarcurso")]
        public ActionResult Get()
        {
            var listacursos = new List<Cursos>();
            using (db)
            {
                foreach (var item in db.Curso)
                {
                    listacursos.Add(item);
                }
            }

            return Ok(listacursos);

        }

        [HttpPost]
        [Route("cadastrarcurso")]
        public ActionResult Post(Cursos curso)
        {
            using (db)
            {
                db.Curso.Add(curso);
                db.SaveChanges();
            }
            return Ok("Curso adicionado com Sucesso!");
        }
        [HttpDelete]
        [Route("deletarcurso")]
        public ActionResult Delete(string nome)
        {
            using (db)
            {
                var deletado = db.Curso.FirstOrDefault(q => q.Nome == nome);
                db.Curso.Remove(deletado);
                db.SaveChanges();
            }
            return Ok("Curso removido do sistema.");
        }
    }
}

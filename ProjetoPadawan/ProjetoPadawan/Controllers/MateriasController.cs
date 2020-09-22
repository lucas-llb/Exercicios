using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetoPadawan.Data;
using ProjetoPadawan.Models;

namespace ProjetoPadawan.Controllers
{
    [Route("MateriaController")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        private readonly AlunoContext db = new AlunoContext();
        [HttpGet]
        [Route("listarmaterias")]
        public ActionResult Get()
        {
            var listarmateria = new List<Materias>();
            foreach (var item in db.Materias)
            {
                listarmateria.Add(item);
            }
            return Ok(listarmateria);
        }

        [HttpPost]
        [Route("cadastrarmateria")]
        public ActionResult Post(Materias materia)
        {
            db.Materias.Add(materia);
            db.SaveChanges();
            return Ok("Matéria cadastrada com sucesso!");
        }

        [HttpDelete]
        [Route("deletarmateria")]
        public ActionResult Delete(string nome)
        {
            try
            {
                var deletado = db.Materias.FirstOrDefault(q => q.Nome == nome);
                db.Materias.Remove(deletado);
                db.SaveChanges();
                return Ok("Materia removida do sistema.");
            }
            catch
            {
                return Ok("Matéria não encontrada!");
            }
        }
    }
}

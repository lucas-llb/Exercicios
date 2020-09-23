using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetoPadawan.Data;
using ProjetoPadawan.Models;

namespace ProjetoPadawan.Controllers
{
    [Route("NotasController")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        private readonly AlunoContext db = new AlunoContext();
        [HttpGet]
        [Route("listarnotas")]
        public ActionResult Get(string nome)
        {
            var listanotas = new List<Notas>();
            using (db)
            {
                listanotas = db.Notas.ToList();
            }

            return Ok(listanotas);
        }

        [HttpPost]
        [Route("cadastrarnota")]
        public ActionResult Post(Notas notas)
        {
            using (db)
            {
                db.Notas.Add(notas);
                db.SaveChanges();
            }
            return Ok("Nota cadastrada com sucesso!");
        }

        [HttpDelete]
        [Route("deletarnotas")]
        public ActionResult Delete(int id)
        {
            using (db)
            {
                var deletado = db.Notas.FirstOrDefault(q => q.Id == id);
                db.SaveChanges();
            }
            return Ok("Nota removida com sucesso.");
        }
    }
}

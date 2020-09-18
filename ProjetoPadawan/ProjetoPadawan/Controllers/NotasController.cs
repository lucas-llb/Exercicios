using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoPadawan.Data;
using ProjetoPadawan.Models;
using ProjetoPadawan.Tools;

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
            var listarNotas = new List<Notas>();
            var listanome = db.Notas;
            foreach (var item in listanome )
            {
                if(listanome.)
                listarNotas.Add(item);
            }
            return Ok(listarNotas);
        }

        [HttpPost]
        [Route("cadastrarnota")]
        public ActionResult Post(Notas notas)
        {
            db.Notas.Add(notas);
            db.SaveChanges();
            return Ok("Nota cadastrada com sucesso!");
        }

        [HttpDelete]
        [Route("deletarnotas")]
        public ActionResult Delete(int id)
        {
            var deletado = db.Notas.FirstOrDefault(q => q.Id == id);
            db.SaveChanges();
            return Ok("Nota removida com sucesso.");
        }
    }
}

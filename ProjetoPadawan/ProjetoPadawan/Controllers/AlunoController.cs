using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoModels;
using ProjetoPadawan.Data;
using ProjetoPadawan.Models;
using ProjetoPadawan.Tools;

namespace ProjetoPadawan.Controllers
{
    [ApiController]
    [Route("AlunoController")]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoContext db = new AlunoContext();
        [HttpGet]
        [Route("listaraluno")]
        public ActionResult Get()
        {
            var listaralunos = new List<Alunos>();
            foreach(var item in db.Aluno)
            {
                listaralunos.Add(item);
            }

            return Ok(listaralunos);
        }

        [HttpPost]
        [Route("cadastraraluno")]
        public ActionResult Post(Alunos aluno)
        {
            db.Aluno.Add(aluno);
            db.SaveChanges();
            return Ok("Aluno cadastrado com sucesso!");
        }

        [HttpDelete]
        [Route("deletaraluno")]
        public ActionResult Delete(string cpf)
        {
            var deletado = db.Aluno.FirstOrDefault(q => q.Cpf == cpf);
            db.Aluno.Remove(deletado);
            db.SaveChanges();
            return Ok("Aluno removido do sistema.");
        }
    }
}

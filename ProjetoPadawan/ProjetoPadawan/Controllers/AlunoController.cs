using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoModels;
using ProjetoPadawan.Models;
using ProjetoPadawan.Tools;

namespace ProjetoPadawan.Controllers
{
    [ApiController]
    [Route("AlunoController")]
    public class AlunoController : ControllerBase
    {
        [HttpGet]
        [Route("listaraluno")]
        public ActionResult Get()
        {
            var alunos = new List<Alunos>();
            var gravaraluno = new GravarAlunos();
            alunos = gravaraluno.Result();

            return Ok(alunos);
        }

        [HttpPost]
        [Route("cadastraraluno")]
        public ActionResult Post(Alunos aluno)
        {
            var gravaraluno = new GravarAlunos();
            gravaraluno.Add(aluno);
            return Ok(aluno);
        }

        [HttpDelete]
        [Route("deletaraluno")]
        public ActionResult Delete(int id)
        {
            var gravaraluno = new GravarAlunos();
            gravaraluno.Deletar(id);
            return Ok("Aluno removido do sistema.");
        }
    }
}

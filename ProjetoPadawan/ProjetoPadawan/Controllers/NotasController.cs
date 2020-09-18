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
    [Route("NotasController")]
    [ApiController]
    public class NotasController : ControllerBase
    {
        [HttpGet]
        [Route("listarnotas")]
        public ActionResult Get()
        {
            var notas = new List<Notas>();
            var gravarnotas = new GravarNotas();
            notas = gravarnotas.Result();
            return Ok(notas);
        }

        [HttpPost]
        [Route("cadastrarnota")]
        public ActionResult Post(Notas notas)
        {
            var gravarnotas = new GravarNotas();
            gravarnotas.Add(notas);
            return Ok(notas);
        }

        [HttpDelete]
        [Route("deletarnotas")]
        public ActionResult Delete(int id)
        {
            var gravarnotas = new GravarNotas();
            gravarnotas.Deletar(id);
            return Ok("Nota removida com sucesso.");
        }
    }
}

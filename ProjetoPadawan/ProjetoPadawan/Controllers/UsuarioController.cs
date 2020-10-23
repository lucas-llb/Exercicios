using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoModels.Models;
using ProjetoPadawan.Data;

namespace ProjetoPadawan.Controllers
{
    [Route("UsuarioController")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly AlunoContext db = new AlunoContext();
        [HttpGet]
        [Route("verificausuario")]
        public ActionResult Get()
        {
            var listausuario = new List<Usuarios>();
            using (db)
            {
                foreach(var item in db.Usuarios)
                {
                    listausuario.Add(item);
                }
            }
            return Ok(listausuario);
        }
        [HttpPost]
        [Route("cadastrausuario")]
        public ActionResult Post(Usuarios usuario)
        {
            using (db)
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
            }
            return Ok("Usuário cadastrado com sucesso!");
        }
        [HttpDelete]
        [Route("deletarususario")]
        public ActionResult Delete(string usuario)
        {
            using (db)
            {
                var deletado = db.Usuarios.FirstOrDefault(q => q.Username == usuario);
                db.Usuarios.Remove(deletado);
                db.SaveChanges();
            }
            return Ok("Usuário deletado com sucesso!");
        }

    }
}

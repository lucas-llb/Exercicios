using LiteDB;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPadawan.Tools
{
    public class GravarCursos
    {
        public void Add(Cursos cursos)
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\ProjetoPadawan.db"))
            {
                liteDB.GetCollection<Cursos>().Insert(cursos);
            }
        }
        public void Deletar(int id)
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\ProjetoPadawan.db"))
            {
                liteDB.GetCollection<Cursos>().DeleteMany(q => q.Id == id);
            }

        }
        public List<Cursos> Result()
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\ProjetoPadawan.db"))
            {
                var a = liteDB.GetCollection<Cursos>().FindAll().ToList();
                return a;
            }

        }
    }
}

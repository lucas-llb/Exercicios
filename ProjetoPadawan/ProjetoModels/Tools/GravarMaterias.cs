using LiteDB;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPadawan.Tools
{
    public class GravarMaterias
    {
        public void Add(Materias materia)
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\ProjetoPadawan.db"))
            {
                liteDB.GetCollection<Materias>().Insert(materia);
            }
        }
        public void Deletar(int id)
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\ProjetoPadawan.db"))
            {
                liteDB.GetCollection<Materias>().DeleteMany(q => q.Id == id);
            }

        }
        public List<Materias> Result()
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\ProjetoPadawan.db"))
            {
                var a = liteDB.GetCollection<Materias>().FindAll().ToList();
                return a;
            }

        }
    }
}

using LiteDB;
using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPadawan.Tools
{
    public class GravarNotas
    {
        public void Add(Notas notas)
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\ProjetoPadawan.db"))
            {
                liteDB.GetCollection<Notas>().Insert(notas);
            }
        }
        public void Deletar(int id)
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\ProjetoPadawan.db"))
            {
                liteDB.GetCollection<Notas>().DeleteMany(q => q.Id == id);
            }

        }
        public List<Notas> Result()
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\ProjetoPadawan.db"))
            {
                var a = liteDB.GetCollection<Notas>().FindAll().ToList();
                return a;
            }

        }
    }
}

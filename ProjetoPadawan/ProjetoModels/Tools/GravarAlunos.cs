using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiteDB;
using ProjetoPadawan.Models;

namespace ProjetoPadawan.Tools
{
    public class GravarAlunos
    {
        public void Add(Alunos alunos)
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\ProjetoPadawan.db"))
            {
                liteDB.GetCollection<Alunos>().Insert(alunos);
            }
        }
        public void Deletar(string cpf)
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\ProjetoPadawan.db"))
            {
                liteDB.GetCollection<Alunos>().DeleteMany(q => q.Cpf == cpf);
            }

        }
        public List<Alunos> Result()
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\ProjetoPadawan.db"))
            {
                var a = liteDB.GetCollection<Alunos>().FindAll().ToList();
                return a;
            }

        }
    }
}

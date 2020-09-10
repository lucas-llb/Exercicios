using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaidSolution.Models;
using LiteDB;


namespace RaidSolution.Ferramentas
{
    public class GravarHeroiDB
    {
        public void Add(Heroi heroi)
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\meubancoRaid.db"))
            {
                liteDB.GetCollection<Heroi>().Insert(heroi);
            }

        }
        public List<Heroi> Result()
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\meubancoRaid.db"))
            {
                var a = liteDB.GetCollection<Heroi>().FindAll().ToList();
                return a;
            }
        }
        public void Deletar(string nome)
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\meubancoRaid.db"))
            {
                liteDB.GetCollection<Heroi>().DeleteMany(q => q.Nome == nome);
            }

        }
        public void Update(Heroi heroi)
        {
            using (var liteDB = new LiteDatabase(@"c:\Teste\meubancopadawan.db"))
            {
                liteDB.GetCollection<Heroi>().Update(heroi);
            }

        }
    }
}

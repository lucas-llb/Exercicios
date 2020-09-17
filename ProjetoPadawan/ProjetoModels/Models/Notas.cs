using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPadawan.Models
{
    public class Notas
    {
        public int Id { get; set; }
        public string Aluno { get; set; }
        public string Materia { get; set; }
        public int Nota { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPadawan.Models
{
    public class Notas
    {
        public int Id { get; set; }
        public int Nota { get; set; }
        public int IdAluno { get; set; }
        public int IdMateria { get; set; }

        public virtual Materias Materia { get; set; }
        public virtual Alunos Aluno { get; set; }
    }
}

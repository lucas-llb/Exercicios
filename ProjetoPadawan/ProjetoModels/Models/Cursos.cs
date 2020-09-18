using ProjetoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPadawan.Models
{
    public class Cursos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Materia { get; set; }
        public string Situacao { get; set; }
        public virtual ICollection<Alunos> Alunos { get; set; }
        //public virtual ICollection<Materias> Materias { get; set; }
        public virtual ICollection<CursosMaterias> CursoMateria {get; set;}
        public Cursos()
        {
            CursoMateria = new HashSet<CursosMaterias>();
            //Materias = new HashSet<Materias>();
            Alunos = new HashSet<Alunos>();
        }
    }
}

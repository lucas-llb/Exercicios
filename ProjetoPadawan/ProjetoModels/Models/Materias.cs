using ProjetoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPadawan.Models
{
    public class Materias : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Situacao { get; set; }
        //public virtual ICollection<Cursos> Curso { get; set; }
        public virtual ICollection<Notas> Nota { get; set; }
        public virtual ICollection<CursosMaterias> CursosMaterias { get; set; }
        public Materias()
        {
            Nota = new HashSet<Notas>();
            //Curso = new HashSet<Cursos>();
            CursosMaterias = new HashSet<CursosMaterias>();
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}

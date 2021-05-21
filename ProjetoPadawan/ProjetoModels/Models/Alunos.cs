using ProjetoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoPadawan.Models
{
    public class Alunos : BaseEntity
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public Guid IdCurso { get; set; }
        public virtual Cursos Curso { get; set; }
        public virtual ICollection<Notas> Notas { get; set; }

        public override string ToString()
        {
            return this.Nome;
        }

        public static string FormataCpf(string cpf)
        {
            var rgx = new Regex(@"^\d{11}$");
            if (rgx.IsMatch(cpf))
            {
                var cpf2 = cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                return cpf2;
            }
            else return cpf;
        }
    }
    
}

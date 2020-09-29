using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjetoModels.Validadores
{
    public class CursoValidador
    {
        public Validador validador = new Validador();

        public Validador validaCurso (Cursos cursos)
        {
            if (cursos.Nome == null)
            {
                validador.IsValid = false;
                validador.Erro.Add("Nome do curso não pode ser nulo!");
            }
            if(cursos.Materia == null)
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo matéria não pode ser nulo!");
            }
            return validador;
        }

        public bool validaNome (string nome)
        {
            var rgxnome = new Regex(@"([A-Z]|[a-z]|\s)*");
            if (rgxnome.IsMatch(nome))
                return true;
            else
                return false;
        }
    }
}

using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjetoModels.Validadores
{
    public class MateriaValidador
    {
        public Validador validador = new Validador();

        public Validador validaMateria(Materias materias)
        {
            if (materias.Nome == null)
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo nome não pode ser nulo!");
            }
            if (materias.Descricao == null)
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo descrição não pode ser nulo!");
            }
            if(materias.DataCadastro == null)
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo data não pode ser vazio!");
            }
            if (!validaNome(materias.Nome))
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo Nome aceita apenas letras!");
            }
            if (!validaNome(materias.Descricao))
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo Descrição aceita apenas letras!");
            }
            if (!validaData(Convert.ToString(materias.DataCadastro)))
            {
                validador.IsValid = false;
                validador.Erro.Add("A data digitada não é válida!");
            }
            return validador;
        }
        public bool validaNome(string nome)
        {
            var rgx = new Regex(@"([A-Z]|[a-z]|\s)*");
            if (rgx.IsMatch(nome))
            {
                return true;
            }
            else return false;
        }
        public bool validaData(string data)
        {
            var rgx = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-](((19\d\d))|((20)([01]\d|20)))$");
            if (rgx.IsMatch(data))
            {
                return true;
            }
            else return false;
        }
    }
}

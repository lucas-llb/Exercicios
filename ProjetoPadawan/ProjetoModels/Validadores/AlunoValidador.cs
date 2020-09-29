using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjetoModels.Validadores
{
    public class AlunoValidador
    {
        public Validador validador = new Validador();

        public Validador Validar (Alunos aluno)
        {
            if (aluno.Nome == null)
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo nome não pode ser nulo!");
            }
            if (!NomeLetras(aluno.Nome))
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo nome deve conter apenas letras!");
            }
            if(aluno.Sobrenome == null)
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo sobrenome não pode ser nulo!");
            }
            if (!CpfNumero(aluno.Cpf))
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo cpf deve conter apenas números!");
            }
            if (!ValidaData(Convert.ToString(aluno.DataNascimento)))
            {
                validador.IsValid = false;
                validador.Erro.Add("O campo data não apresenta uma data válida!");
            }
            return validador;
        }

        public bool NomeLetras (string nome)
        {
            var rgxNome = new Regex(@"[a-z]|[A-Z]|\s");
            if (rgxNome.IsMatch(nome))
                return true;
            else
                return false;
        }
        public bool CpfNumero(string cpf)
        {
            var rgxcpf = new Regex(@"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$");
            if (rgxcpf.IsMatch(cpf))
                return true;
            else
                return false;
        }
        public bool ValidaData(string data)
        {
            var rgx = new Regex(@"^((0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]((19)\d\d))|((0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-](20[01]{2}))|((0?[1])[\/\-](0?1)[\/\-](2002))");
            if (rgx.IsMatch(data))
                return true;
            else
                return false;
        }


    }
}

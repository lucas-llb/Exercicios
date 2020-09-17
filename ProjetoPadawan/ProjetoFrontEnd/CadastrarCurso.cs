using ProjetoPadawan.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjetoFrontEnd
{
    public partial class CadastrarCurso : Form
    {
        public CadastrarCurso()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            var curso = new Cursos();
            var rgxnome = new Regex(@"([A-Z]|[a-z]|\s)*");
            if (rgxnome.IsMatch(txt_nome.Text))
            {
                curso.Nome = txt_nome.Text;
                if(txt_situacao.Text.ToUpper() == "ATIVO" || txt_situacao.Text.ToUpper() == "INATIVO")
                {
                    curso.Materia = txt_materia.Text;
                    curso.Situacao = txt_situacao.Text;
                    lbl_erro.Text = "";
                    lbl_success.Text = "Curso cadastrado com sucesso!";
                }
                else
                {
                    lbl_erro.Text = "Por favor digite apenas ATIVO ou INATIVO!";
                }
            }
            else
            {
                lbl_erro.Text = "O campo Nome aceita apenas letras!";
            }


        }
    }
}

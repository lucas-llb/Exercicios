using ProjetoPadawan.Models;
using ProjetoPadawan.Tools;
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
    public partial class CadastroMateria : Form
    {
        private readonly GravarMaterias gravarMateriasDB;
        public CadastroMateria()
        {
            InitializeComponent();
            gravarMateriasDB = new GravarMaterias();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            var materias = new Materias();
            var rgxdata = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]((19|20)([01]\d|20))$");
            var rgxdescricao = new Regex(@"([A-Z]|[a-z]|\s)*");
            if (rgxdescricao.IsMatch(txt_nome.Text))
            {
                materias.Nome = txt_nome.Text;
                if (rgxdata.IsMatch(txt_datacadastro.Text))
                {
                    materias.DataCadastro = Convert.ToDateTime(txt_datacadastro.Text);
                    if (rgxdescricao.IsMatch(txt_descricao.Text))
                    {
                        if (txt_situacao.Text.ToUpper() == "ATIVO" || txt_situacao.Text.ToUpper() == "INATIVO")
                        {
                            materias.Situacao = txt_situacao.Text;
                            lbl_erro.Text = "";
                            lbl_success.Text = "Matéria salva com sucesso!";
                        }
                        else
                        {
                            lbl_erro.Text = "Por favor digite apenas ATIVO ou INATIVO!";
                        }
                        materias.Descricao = txt_descricao.Text;
                    }
                    else
                    {
                        lbl_erro.Text = "Apanas letras são permitidas na descrição!";
                    }

                }
                else
                {
                    lbl_erro.Text = "Informe uma data válida!";
                }
            }
            else
            {
                lbl_erro.Text = "O campo Nome deve conter apenas letras!";
            }

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }
    }
}

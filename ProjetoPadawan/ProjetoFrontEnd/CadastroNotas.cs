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
    public partial class CadastroNotas : Form
    {
        public CadastroNotas()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            var nota = new Notas();
            var rgxaluno = new Regex(@"([A-Z]|[a-z]|\s)*");
            var rgxnota = new Regex(@"^([1-9]?\d|100)$");
            if (rgxaluno.IsMatch(txt_aluno.Text))
            {
                nota.Aluno = txt_aluno.Text;
                if (rgxnota.IsMatch(txt_nota.Text))
                {
                    nota.Nota = Convert.ToInt32(txt_nota.Text);
                    nota.Materia = txt_aluno.Text;
                }
                else
                {
                    lbl_erro.Text = "Campo nota deve conter apenas números";
                }

             }
        }
    }
}

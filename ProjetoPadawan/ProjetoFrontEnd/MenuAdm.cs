using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFrontEnd
{

    public partial class MenuAdm : Form
    {
        CadastroMateria CadMat = new CadastroMateria();
        CadastrarCurso CadCur = new CadastrarCurso();
        CadastrarAluno CadAlu = new CadastrarAluno();
        public MenuAdm()
        {
            InitializeComponent();
        }

        private void btn_cadCurso_Click(object sender, EventArgs e)
        {
            CadCur.ShowDialog();
            this.Close();
        }

        private void btn_cadAluno_Click(object sender, EventArgs e)
        {
            CadAlu.ShowDialog();
            this.Close();
        }

        private void btn_cadMateria_Click(object sender, EventArgs e)
        {
            CadMat.ShowDialog();
            this.Close();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            var inicio = new Inicio();
            this.Hide();
            inicio.Show();
        }
    }
}

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
        public MenuAdm()
        {
            InitializeComponent();
        }

        private void btn_cadCurso_Click(object sender, EventArgs e)
        {
            CadastrarCurso CadCur = new CadastrarCurso();
            CadCur.ShowDialog();
        }

        private void btn_cadAluno_Click(object sender, EventArgs e)
        {
            CadastrarAluno CadAlu = new CadastrarAluno();
            CadAlu.ShowDialog();
        }

        private void btn_cadMateria_Click(object sender, EventArgs e)
        {
            CadastroMateria CadMat = new CadastroMateria();
            CadMat.ShowDialog();

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

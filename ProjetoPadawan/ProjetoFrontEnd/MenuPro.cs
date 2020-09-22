using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFrontEnd
{

    public partial class MenuPro : Form
    {
        CadastroMateria CadMat = new CadastroMateria();
        CadastrarCurso CadCur = new CadastrarCurso();
        CadastrarAluno CadAlu = new CadastrarAluno();
        CadastroNotas CadNota = new CadastroNotas();
        public MenuPro()
        {
            InitializeComponent();
        }

        private void btn_cadCurso_Click(object sender, EventArgs e)
        {
            CadCur.ShowDialog();
          
        }

        private void btn_cadAluno_Click(object sender, EventArgs e)
        {
            CadAlu.ShowDialog();
        }

        private void btn_cadMateria_Click(object sender, EventArgs e)
        {

            CadMat.ShowDialog();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cadNota_Click(object sender, EventArgs e)
        {
            CadNota.ShowDialog();
            //this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFrontEnd
{

    public partial class MenuAluno : Form
    {
        //Inicio inicio = new Inicio();
        CadastroMateria CadMat = new CadastroMateria();
        CadastrarCurso CadCur = new CadastrarCurso();
        CadastrarAluno CadAlu = new CadastrarAluno();
        ListarNotas ListNota = new ListarNotas();
        public MenuAluno()
        {
            InitializeComponent();
        }

        private void btn_cadCurso_Click(object sender, EventArgs e)
        {
            CadCur.Show();
           // this.Hide();
        }

        private void btn_cadAluno_Click(object sender, EventArgs e)
        {
            CadAlu.Show();
            //this.Hide();
        }

        private void btn_cadMateria_Click(object sender, EventArgs e)
        {
            CadMat.Show();
            //this.Hide();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ListNota_Click(object sender, EventArgs e)
        {
            ListNota.ShowDialog();
            //this.Hide();
        }
    }
}

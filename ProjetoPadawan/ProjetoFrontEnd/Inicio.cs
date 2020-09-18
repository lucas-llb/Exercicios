using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFrontEnd
{
    public partial class Inicio : Form
    {
        MenuAdm menuAdm = new MenuAdm();
        MenuAluno menuAluno = new MenuAluno();
        MenuPro menuPro = new MenuPro();
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_aluno_Click(object sender, EventArgs e)
        {
            menuAluno.ShowDialog();
            this.Close();
        }

        private void btn_professor_Click(object sender, EventArgs e)
        {
            menuPro.ShowDialog();
            this.Close();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            menuAdm.ShowDialog();
            this.Close();
        }
    }
}

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
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_aluno_Click(object sender, EventArgs e)
        {
            MenuAluno menuAluno = new MenuAluno();
            menuAluno.Show();
            //this.Hide();
        }

        private void btn_professor_Click(object sender, EventArgs e)
        {
            MenuPro menuPro = new MenuPro();
            menuPro.Show();
            //this.Hide();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
        MenuAdm menuAdm = new MenuAdm();
            menuAdm.Show();
            //this.Hide();
        }
    }
}

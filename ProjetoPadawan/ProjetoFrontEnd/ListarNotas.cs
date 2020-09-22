using ProjetoModels.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjetoFrontEnd
{
    public partial class ListarNotas : Form
    {
        private readonly GravarNotasApi gravaNotasDB;
        private readonly GravarAlunoApi gravarAlunoApi;
        public ListarNotas()
        {
            InitializeComponent();
            gravaNotasDB = new GravarNotasApi();
            gravarAlunoApi = new GravarAlunoApi();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
            var aluno = box_aluno.Text;
            txt_lista.Text = "";
            //var rgxcpf = new Regex(@"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$");
            if (box_aluno.SelectedItem != null)
            {
                var listanotaas = gravaNotasDB.Result().Where(q => q.Aluno.Nome == aluno);
                foreach (var item in listanotaas)
                {
                    txt_lista.Text += $"ID: {item.Id}\tMatéria: {item.Materia.Nome}\tNota: {item.Nota}{Environment.NewLine}";
                }
            }
            else
            {
                MessageBox.Show("O CPF não é válido.");
            }

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarNotas_Load(object sender, EventArgs e)
        {
            box_aluno.Items.Clear();
            foreach(var item in gravarAlunoApi.Result())
            {
                box_aluno.Items.Add(item);
            }
        }
    }
}

using ProjetoModels.Tools;
using ProjetoPadawan.Models;
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
        private readonly GravarMateriasApi gravarMaterias;
        public ListarNotas()
        {
            InitializeComponent();
            gravaNotasDB = new GravarNotasApi();
            gravarAlunoApi = new GravarAlunoApi();
            gravarMaterias = new GravarMateriasApi();
        }

        private void btn_listar_Click(object sender, EventArgs e)
        {
           
            var aluno = box_aluno.Text;
            txt_lista.Text = "";
            var listaaluno = gravarAlunoApi.Result();
            var listanotas = gravaNotasDB.Result();
            var listamaterias = gravarMaterias.Result();
            var listanotaaluno = new List<Notas>();
            //var rgxcpf = new Regex(@"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$");
            if (box_aluno.SelectedItem != null)
            {
                var alunonota = listaaluno.Where(q => q.Nome == aluno).First();
                foreach(var item in listanotas)
                {
                    if (item.AlunoId == alunonota.Id)
                        listanotaaluno.Add(item);
                }
                
                foreach (var item in listanotaaluno)
                {
                    var materia = listamaterias.Find(q => q.Id == item.MateriaId);
                    txt_lista.Text += $"ID: {item.Id}\tMatéria: {materia.Nome}\t\tNota: {item.Nota}{Environment.NewLine}";
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

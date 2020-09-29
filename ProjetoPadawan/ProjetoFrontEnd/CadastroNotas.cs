using ProjetoModels.Tools;
using ProjetoModels.Validadores;
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
    public partial class CadastroNotas : Form
    {
        private readonly GravarAlunoApi gravarAlunoApi;
        private readonly GravarMateriasApi gravarMateriasApi;
        private readonly GravarNotasApi gravarNotasApi;
        public CadastroNotas()
        {
            InitializeComponent();
            gravarAlunoApi = new GravarAlunoApi();
            gravarMateriasApi = new GravarMateriasApi();
            gravarNotasApi = new GravarNotasApi();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            var listaalunos = gravarAlunoApi.Result().Select(q=>q.Nome);
            var listamaterias = gravarMateriasApi.Result().Where(q => q.Situacao == "ATIVO").Select(q => q.Nome);
            var nota = new Notas();
            var validador = new NotasValidador();
            if (box_aluno.SelectedItem != null)
            {
                nota.AlunoId = ((Alunos)box_aluno.SelectedItem).Id;
                if (box_materias.SelectedItem != null)
                {
                    if (validador.validaNota(txt_nota.Text))
                    {
                        txt_listarnota.Text = "";
                        nota.Nota = Convert.ToInt32(txt_nota.Text);
                        nota.MateriaId = ((Materias)box_materias.SelectedItem).Id;
                        gravarNotasApi.Add(nota);
                        lbl_erro.Text = "";
                        lbl_success.Text = "Nota cadastrada com sucesso!";
                        var listarnota = gravarNotasApi.Result();
                        foreach (var item in listarnota)
                        {
                            var materia = gravarMateriasApi.Result().Find(q => q.Id == item.MateriaId);
                            var aluno = gravarAlunoApi.Result().Find(q => q.Id == item.AlunoId);
                            txt_listarnota.Text += $"Id:{item.Id}\tAluno:{aluno.Nome}\tMatéria:{materia.Nome}\tNota:{item.Nota}{Environment.NewLine}";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Campo nota deve conter apenas números!");
                    }
                }
                else
                {
                    MessageBox.Show("Matéria não encontrada!");
                }
            }
            else
            {
                MessageBox.Show("Aluno não encontrado!");
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            txt_listarnota.Text = "";
            var id = Convert.ToInt32(txt_id.Text);
            gravarNotasApi.Deletar(id);
            var listarnota = gravarNotasApi.Result();
            foreach (var item in listarnota)
            {
                var materia = gravarMateriasApi.Result().Find(q => q.Id == item.MateriaId);
                var aluno = gravarAlunoApi.Result().Find(q => q.Id == item.AlunoId);
                txt_listarnota.Text += $"Id:{item.Id}\tAluno:{aluno.Nome}\tMatéria:{materia.Nome}\tNota:{item.Nota}{Environment.NewLine}";
            }

        }

        private void CadastroNotas_Load(object sender, EventArgs e)
        {
            box_materias.Items.Clear();
            box_aluno.Items.Clear();
            txt_listarnota.Text = "";
            foreach(var item in gravarMateriasApi.Result())
            {
                box_materias.Items.Add(item);
            }
            foreach(var item in gravarAlunoApi.Result())
            {
                box_aluno.Items.Add(item);
            }
            var listarnota = gravarNotasApi.Result();
            foreach (var item in listarnota)
            {
                var materia = gravarMateriasApi.Result().Find(q => q.Id == item.MateriaId);
                var aluno = gravarAlunoApi.Result().Find(q => q.Id == item.AlunoId);
                txt_listarnota.Text += $"Id:{item.Id}\tAluno:{aluno.Nome}\tMatéria:{materia.Nome}\tNota:{item.Nota}{Environment.NewLine}";
            }
        }
    }
}

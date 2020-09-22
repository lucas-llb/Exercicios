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
            var rgxaluno = new Regex(@"([A-Z]|[a-z]|\s)*");
            var rgxnota = new Regex(@"^([1-9]?\d|100)$");
            if (rgxaluno.IsMatch(txt_aluno.Text))
            {
                if (listaalunos.Contains(txt_aluno.Text.ToUpper()))
                {
                    nota.Aluno.Nome = txt_aluno.Text.ToUpper();
                    if (listamaterias.Contains(txt_materia.Text.ToUpper()))
                    {
                        if (rgxnota.IsMatch(txt_nota.Text))
                        {
                            txt_listarnota.Text = "";
                            nota.Nota = Convert.ToInt32(txt_nota.Text);
                            nota.Materia.Nome = txt_materia.Text;
                            gravarNotasApi.Add(nota);
                            lbl_erro.Text = "";
                            lbl_success.Text = "Nota cadastrada com sucesso!";
                            var listarnota = gravarNotasApi.Result();
                            foreach(var item in listarnota)
                            {
                                txt_listarnota.Text += $"Id:{item.Id}\tAluno:{item.Aluno}\tMatéria:{item.Materia}\tNota:{item.Nota}{Environment.NewLine}";
                            }
                        }
                        else
                        {
                            lbl_erro.Text = "Campo nota deve conter apenas números!";
                        }
                    }
                    else
                    {
                        lbl_erro.Text = "Matéria não encontrada!";
                    }
                }
                else
                {
                    lbl_erro.Text = "Aluno não encontrado!";
                }
            }
            else
            {
                lbl_erro.Text = "O campo aluno deve conter apenas letras!";
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
                txt_listarnota.Text += $"Id:{item.Id}\tAluno:{item.Aluno}\tMatéria:{item.Materia}\tNota:{item.Nota}{Environment.NewLine}";
            }

        }
    }
}

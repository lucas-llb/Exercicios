using ProjetoModels.Tools;
using ProjetoPadawan.Models;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ProjetoModels.Validadores;
using ProjetoModels;

namespace ProjetoFrontEnd
{
    public partial class CadastrarAluno : Form
    {
        private readonly GravarAlunoApi gravarAlunosDB;
        private readonly GravarCursosApi gravarCursosApi;
        public CadastrarAluno()
        {
            InitializeComponent();
            gravarAlunosDB = new GravarAlunoApi();
            gravarCursosApi = new GravarCursosApi();

        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            var listacurso = gravarCursosApi.Result();
            var listaNomeCurso = listacurso.Where(q => q.Situacao == "ATIVO").Select(q => q.Nome);
            var Validadores = new AlunoValidador();
            var aluno = new Alunos();
            if (txt_nome.Text != null && txt_sobrenome.Text != null && txt_datanasc.Text != null && txt_cpf.Text != null && box_curso.SelectedItem != null)
            {
                if (Validadores.ValidaData(txt_datanasc.Text))
                {
                    aluno.DataNascimento = Convert.ToDateTime(txt_datanasc.Text);
                    if (Validadores.NomeLetras(txt_nome.Text))
                    {
                        aluno.Nome = txt_nome.Text.ToUpper();
                        if (Validadores.CpfNumero(txt_cpf.Text))
                        {
                            aluno.Sobrenome = txt_sobrenome.Text.ToUpper();
                            var cpf = Validadores.FormataCpf(txt_cpf.Text);
                            aluno.Cpf = cpf;
                            txt_listaaluno.Text = "";
                            aluno.IdCurso = ((Cursos)box_curso.SelectedItem).Id;
                            gravarAlunosDB.Add(aluno);
                            MessageBox.Show("Cadastro feito com sucesso!", "Chique demais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var listaaluno = gravarAlunosDB.Result();
                            foreach (var item in listaaluno)
                            {
                                string txtt = String.Format("Aluno:{0,-10}\t CPF:{1,-5} \n", item.Nome, item.Cpf);
                                //txt_listaaluno.Text += $"Aluno:{item.Nome}\tCPF:{item.Cpf}{Environment.NewLine}";
                                txt_listaaluno.Text += txtt;
                                box_excluir.Items.Add(item);
                            }
                        }
                        else
                        {
                            MessageBox.Show("O CPF não é válido!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("O nome não pode ter números ou caracteres especiais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("A data não está em formato correto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Há campos que devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txt_nome.Text = "";
            txt_sobrenome.Text = "";
            txt_datanasc.Text = "";
            txt_cpf.Text = "";
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            txt_listaaluno.Text = "";
            var Validadores = new AlunoValidador();
            if (txt_cpf.Text is null)
            {
                MessageBox.Show("Confirme o CPF para excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Validadores.CpfNumero(txt_cpf.Text))
                {
                    if (box_excluir.SelectedItem != null)
                    {
                        var aluno = (Alunos)box_excluir.SelectedItem;
                        var cpf = Validadores.FormataCpf(txt_cpf.Text);
                        if (aluno.Cpf == cpf)
                        {
                            gravarAlunosDB.Deletar(cpf);
                            MessageBox.Show("Aluno deletado com sucesso!", "Chique demais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var listaaluno = gravarAlunosDB.Result();
                            foreach (var item in listaaluno)
                            {
                                string txtt = String.Format("Aluno:{0,-10}\t CPF:{1,-5} \n", item.Nome, item.Cpf);
                                txt_listaaluno.Text += txtt;
                                box_excluir.Items.Add(item);
                            }
                        }
                        else
                        {
                            MessageBox.Show("CPF e aluno não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Selecione um aluno para excluir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Digite um CPF válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void CadastrarAluno_Load(object sender, EventArgs e)
        {
            box_curso.Items.Clear();
            box_excluir.Items.Clear();
            foreach (var item in gravarCursosApi.Result())
            {
                box_curso.Items.Add(item);
            }
            foreach (var item in gravarAlunosDB.Result())
            {
                box_excluir.Items.Add(item);
                string txtt = String.Format("Aluno:{0,-10}\t CPF:{1,-5} \n", item.Nome, item.Cpf);
                //txt_listaaluno.Text += $"Aluno:{item.Nome}\tCPF:{item.Cpf}{Environment.NewLine}";
                txt_listaaluno.Text += txtt;
            }
        }
    }
}


//Regex(@"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]((19|20)([01]\d|20))$");  <<< regex data até 2020
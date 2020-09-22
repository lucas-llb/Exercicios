using ProjetoModels.Tools;
using ProjetoPadawan.Models;
using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


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
            var aluno = new Alunos();
            var rgxNome = new Regex(@"[a-z]|[A-Z]|\s");
            var rgxcpf = new Regex(@"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$");
            var rgx = new Regex(@"^((0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]((19)\d\d))|((0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-](20[01]{2}))|((0?[1])[\/\-](0?1)[\/\-](2002))"); 
            if (txt_nome.Text != null && txt_sobrenome.Text != null && txt_datanasc != null && txt_curso.Text != null && txt_cpf.Text != null)
            {
                if (rgx.IsMatch(txt_datanasc.Text))
                {
                    aluno.DataNascimento = Convert.ToDateTime(txt_datanasc.Text);
                    if (rgxNome.IsMatch(txt_nome.Text))
                    {
                        aluno.Nome = txt_nome.Text.ToUpper();
                        if (rgxcpf.IsMatch(txt_cpf.Text))
                        {
                            aluno.Sobrenome = txt_sobrenome.Text.ToUpper();
                            aluno.Cpf = txt_cpf.Text;
                            if (listaNomeCurso.Contains(txt_curso.Text.ToUpper()))
                            {
                                
                                var curso = listacurso.Where(q => q.Nome == txt_curso.Text.ToUpper()).Select(q => q.Id);
                                txt_listaaluno.Text = "";
                                //aluno.Curso.Nome = txt_curso.Text.ToUpper();
                                aluno.IdCurso = curso.FirstOrDefault(); 
                                gravarAlunosDB.Add(aluno);
                                lbl_erro.Text = "";
                                lbl_succes.Text = "Cadastro feito com sucesso!";
                                var listaaluno = gravarAlunosDB.Result();
                                foreach(var item in listaaluno)
                                {
                                    txt_listaaluno.Text += $"Aluno:{item.Nome}\tCPF:{item.Cpf}{Environment.NewLine}";
                                }
                            }
                            else
                            {
                                lbl_erro.Text = "Curso não foi cadastrado!";
                            }
                        

                        }
                        else
                        {
                            lbl_erro.Text = "O CPF não é válido!";
                        }
                    }
                    else
                    {
                        lbl_erro.Text =  "O nome não pode ter números ou caracteres especiais!";
                    }

                }
                else
                {
                    lbl_erro.Text = "A data não está em formato correto!";
                }
                
            }
            else
            {
                lbl_erro.Text = "Há campos que devem ser preenchidos!";
            }

            txt_nome.Text = "";
            txt_sobrenome.Text = "";
            txt_datanasc.Text = "";
            txt_cpf.Text = "";
            txt_curso.Text = "";
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            txt_listaaluno.Text = "";
            var rgxcpf = new Regex(@"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$");
            if(txt_cpf.Text is null)
            {
                lbl_erro.Text = "Digite um cpf válido para deletar um aluno.";
            }
            else
            {
                if (rgxcpf.IsMatch(txt_cpf.Text))
                {
                    gravarAlunosDB.Deletar(txt_cpf.Text);
                    var listaaluno = gravarAlunosDB.Result();
                    foreach (var item in listaaluno)
                    {
                        txt_listaaluno.Text += $"Aluno:{item.Nome}\tCPF:{item.Cpf}{Environment.NewLine}";
                    }
                }
                else
                {
                    lbl_erro.Text = "Digite um CPF válido!";
                }
            }


        }
    }
}


//Regex(@"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]((19|20)([01]\d|20))$");  <<< regex data até 2020
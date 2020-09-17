﻿using ProjetoPadawan.Models;
using ProjetoPadawan.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace ProjetoFrontEnd
{
    public partial class CadastrarAluno : Form
    {
        private readonly GravarAlunos gravarAlunosDB;
        public CadastrarAluno()
        {
            InitializeComponent();
            gravarAlunosDB = new GravarAlunos();


        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            var url = "rota";
            var httpClient = new HttpClient();
            var resultRequest = httpClient.GetAsync(url);  //post ou delete
            resultRequest.Wait();
            var result = resultRequest.Result.Content.ReadAsStringAsync();
            result.Wait();
            



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
                        aluno.Nome = txt_nome.Text;
                        if (rgxcpf.IsMatch(txt_cpf.Text))
                        {
                            aluno.Sobrenome = txt_sobrenome.Text;
                            aluno.Cpf = txt_cpf.Text;
                            aluno.Curso = txt_curso.Text;
                            gravarAlunosDB.Add(aluno);
                            lbl_erro.Text = "";
                            lbl_succes.Text = "Cadastro feito com sucesso!";
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
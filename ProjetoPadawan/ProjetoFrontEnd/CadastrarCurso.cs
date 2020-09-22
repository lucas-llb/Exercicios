﻿using ProjetoModels.Tools;
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
    public partial class CadastrarCurso : Form
    {
        private readonly GravarCursosApi gravarCursosApi;
        private readonly GravarMateriasApi gravarMateriasApi;
        public CadastrarCurso()
        {
            InitializeComponent();
            gravarCursosApi = new GravarCursosApi();
            gravarMateriasApi = new GravarMateriasApi();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            var listamaterias = gravarMateriasApi.Result().Where(q => q.Situacao == "ATIVO").Select(q => q.Nome);
            var curso = new Cursos();
            var rgxnome = new Regex(@"([A-Z]|[a-z]|\s)*");
            if (rgxnome.IsMatch(txt_nome.Text))
            {
                curso.Nome = txt_nome.Text.ToUpper();
                if(box_situacao.SelectedItem != null)
                {
                    if (box_materias.SelectedItem != null)
                    {
                        txt_listacurso.Text = "";
                        curso.Materia = box_materias.Text.ToUpper();
                        curso.Situacao = box_situacao.Text;
                        gravarCursosApi.Add(curso);
                        lbl_erro.Text = "";
                        MessageBox.Show("Curso cadastrado com sucesso!");
                        var listacurso = gravarCursosApi.Result();
                        foreach(var item in listacurso)
                        {
                            txt_listacurso.Text += $"{item.Nome}{Environment.NewLine}";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Materia não encontrada!");
                    }

                }
                else
                {
                    MessageBox.Show("Por favor digite apenas ATIVO ou INATIVO!");
                }
            }
            else
            {
                MessageBox.Show("O campo Nome aceita apenas letras!");

            }


        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            txt_listacurso.Text = "";
            var nome = txt_nome.Text.ToUpper();
            var rgxnome = new Regex(@"([A-Z]|[a-z]|\s)*");
            if (rgxnome.IsMatch(nome))
            {
                gravarCursosApi.Deletar(nome);
                var listacurso = gravarCursosApi.Result();
                foreach (var item in listacurso)
                {
                    txt_listacurso.Text += $"{item.Nome}{Environment.NewLine}";
                }
            }
            
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void CadastrarCurso_Load(object sender, EventArgs e)
        {
            box_materias.Items.Clear();
            foreach(var item in gravarMateriasApi.Result())
            {
                box_materias.Items.Add(item);
            }

        }
    }
}

using ProjetoModels.Tools;
using ProjetoModels.Validadores;
using ProjetoPadawan.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjetoFrontEnd
{
    public partial class CadastroMateria : Form
    {
        private readonly GravarMateriasApi gravarMateriasDB;
        public CadastroMateria()
        {
            InitializeComponent();
            gravarMateriasDB = new GravarMateriasApi();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            var materias = new Materias();
            var validador = new MateriaValidador();
            if (validador.validaNome(txt_nome.Text))
            {
                materias.Nome = txt_nome.Text.ToUpper();
                if (validador.validaData(txt_datacadastro.Text))
                {
                    materias.DataCadastro = Convert.ToDateTime(txt_datacadastro.Text);
                    if (validador.validaNome(txt_descricao.Text))
                    {
                        materias.Descricao = txt_descricao.Text;
                        if (box_situacao.SelectedItem != null)
                        {
                            txt_listarmateria.Text = "";
                            materias.Situacao = box_situacao.Text;
                            gravarMateriasDB.Add(materias);
                            lbl_erro.Text = "";
                            MessageBox.Show("Matéria salva com sucesso!");
                            var listarmateria = gravarMateriasDB.Result();
                            foreach (var item in listarmateria)
                            {
                                txt_listarmateria.Text += $"{item.Nome}{Environment.NewLine}";
                                box_excluir.Items.Add(item);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, entre com a situação!");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Apanas letras são permitidas na descrição!");
                    }

                }
                else
                {
                    MessageBox.Show("Informe uma data válida!");
                }
            }
            else
            {
                MessageBox.Show("O campo Nome deve conter apenas letras!");
            }

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            // MenuAdm menuadm = new MenuAdm();
            // menuadm.Show();
            this.Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if(box_excluir.SelectedItem != null)
            {
                var nome = box_excluir.Text;
                gravarMateriasDB.Deletar(nome);
                var listarmateria = gravarMateriasDB.Result();
                foreach (var item in listarmateria)
                {
                    txt_listarmateria.Text += $"{item.Nome}{Environment.NewLine}";
                    box_excluir.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma matéria para ser excluída!");
            }

        }

        private void CadastroMateria_Load(object sender, EventArgs e)
        {
            box_excluir.Items.Clear();
            foreach (var item in gravarMateriasDB.Result())
            {
                box_excluir.Items.Add(item);
            }
        }
    }
}

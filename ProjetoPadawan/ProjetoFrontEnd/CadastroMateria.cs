using ProjetoModels.Tools;
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
            var rgxdata = new Regex(@"^(0?[1-9]|[12][0-9]|3[01])[\/\-](0?[1-9]|1[012])[\/\-]((19|20)([01]\d|20))$");
            var rgxdescricao = new Regex(@"([A-Z]|[a-z]|\s)*");
            if (rgxdescricao.IsMatch(txt_nome.Text))
            {
                materias.Nome = txt_nome.Text.ToUpper();
                if (rgxdata.IsMatch(txt_datacadastro.Text))
                {
                    materias.DataCadastro = Convert.ToDateTime(txt_datacadastro.Text);
                    if (rgxdescricao.IsMatch(txt_descricao.Text))
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
                            foreach(var item in listarmateria)
                            {
                                txt_listarmateria.Text += $"{item.Nome}{Environment.NewLine}";
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
            var nome = txt_nome.Text.ToUpper();
            gravarMateriasDB.Deletar(nome);
            var listarmateria = gravarMateriasDB.Result();
            foreach (var item in listarmateria)
            {
                txt_listarmateria.Text += $"{item.Nome}{Environment.NewLine}";
            }
        }
    }
}

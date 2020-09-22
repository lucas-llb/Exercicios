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
                        if (txt_situacao.Text.ToUpper() == "ATIVO" || txt_situacao.Text.ToUpper() == "INATIVO")
                        {
                            txt_listarmateria.Text = "";
                            materias.Situacao = txt_situacao.Text.ToUpper();
                            gravarMateriasDB.Add(materias);
                            lbl_erro.Text = "";
                            lbl_success.Text = "Matéria salva com sucesso!";
                            var listarmateria = gravarMateriasDB.Result();
                            foreach(var item in listarmateria)
                            {
                                txt_listarmateria.Text += $"{item.Nome}{Environment.NewLine}";
                            }
                        }
                        else
                        {
                            lbl_erro.Text = "Por favor digite apenas ATIVO ou INATIVO!";
                        }
                        
                    }
                    else
                    {
                        lbl_erro.Text = "Apanas letras são permitidas na descrição!";
                    }

                }
                else
                {
                    lbl_erro.Text = "Informe uma data válida!";
                }
            }
            else
            {
                lbl_erro.Text = "O campo Nome deve conter apenas letras!";
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

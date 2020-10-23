using ProjetoModels.Models;
using ProjetoModels.Tools;
using ProjetoModels.Validadores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFrontEnd
{
    public partial class CadastroUsuario : Form
    {
        private readonly GravarUsuariosApi gravarUsuarios;
        public CadastroUsuario()
        {
            InitializeComponent();
            gravarUsuarios = new GravarUsuariosApi();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            var listaUsuarios = gravarUsuarios.Result().Select(q=>q.Username);
            var validador = new UsuarioValidador();
            var usuario = new Usuarios();
            if(txt_user.Text != null && txt_senha.Text != null && txt_confirmasenha.Text != null && cbo_acesso.SelectedItem != null)
            {
                if (!listaUsuarios.Contains(txt_user.Text))
                {
                    var user = txt_user.Text;
                    if(txt_senha.Text == txt_confirmasenha.Text)
                    {
                        usuario.Username = user;
                        usuario.Password = txt_senha.Text;
                        usuario.Acesso = validador.ValidaAcesso(cbo_acesso.Text);
                        gravarUsuarios.Add(usuario);
                        MessageBox.Show("Cadastro feito com sucesso!", "Chique demais", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("As senhas informadas não são iguais!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nome de usuário já se encontra no sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Há campos que devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using ProjetoModels.Models;
using ProjetoModels.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFrontEnd
{
    public partial class Autenticacao : Form
    {
        private readonly GravarUsuariosApi gravarUsuarios;
        public Autenticacao()
        {
            InitializeComponent();
            gravarUsuarios = new GravarUsuariosApi();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            var listaUsuarios = gravarUsuarios.Result();
            var usuario = new Usuarios();
            if (txt_user.Text != null && txt_password.Text!= null)
            {
                usuario.Username = txt_user.Text;
                usuario.Password = txt_password.Text;
                if (listaUsuarios.Contains(usuario))
                {
                    var verificaSenha = listaUsuarios.Find(q => q.Username == usuario.Username);
                    if(verificaSenha.Password == usuario.Password)
                    {
                        if(usuario.Acesso == 1)
                        {
                            MenuAdm menuAdm = new MenuAdm();
                            menuAdm.ShowDialog();
                        }
                        if(usuario.Acesso == 2)
                        {
                            MenuPro menuPro = new MenuPro();
                            menuPro.ShowDialog();
                        }
                        else
                        {
                            MenuAluno menuAluno = new MenuAluno();
                            menuAluno.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Usuário informado não existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Há campos que devem ser preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

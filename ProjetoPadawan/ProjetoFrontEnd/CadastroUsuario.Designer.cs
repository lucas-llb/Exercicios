namespace ProjetoFrontEnd
{
    partial class CadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_confirmasenha = new System.Windows.Forms.TextBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_acesso = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar senha:";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(124, 118);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(238, 23);
            this.txt_user.TabIndex = 4;
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(124, 151);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(238, 23);
            this.txt_senha.TabIndex = 5;
            // 
            // txt_confirmasenha
            // 
            this.txt_confirmasenha.Location = new System.Drawing.Point(124, 187);
            this.txt_confirmasenha.Name = "txt_confirmasenha";
            this.txt_confirmasenha.Size = new System.Drawing.Size(238, 23);
            this.txt_confirmasenha.TabIndex = 4;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(163, 285);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(142, 46);
            this.btn_gravar.TabIndex = 6;
            this.btn_gravar.Text = "Salvar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(163, 360);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(142, 46);
            this.btn_voltar.TabIndex = 7;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nível de acesso:";
            // 
            // cbo_acesso
            // 
            this.cbo_acesso.FormattingEnabled = true;
            this.cbo_acesso.Items.AddRange(new object[] {
            "1 - Administrador",
            "2 - Professor",
            "3 - Aluno"});
            this.cbo_acesso.Location = new System.Drawing.Point(124, 222);
            this.cbo_acesso.Name = "cbo_acesso";
            this.cbo_acesso.Size = new System.Drawing.Size(238, 23);
            this.cbo_acesso.TabIndex = 8;
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.cbo_acesso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_confirmasenha);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_confirmasenha;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_acesso;
    }
}
namespace ProjetoFrontEnd
{
    partial class MenuAdm
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
            this.btn_cadCurso = new System.Windows.Forms.Button();
            this.btn_cadAluno = new System.Windows.Forms.Button();
            this.btn_cadMateria = new System.Windows.Forms.Button();
            this.btn_cadNota = new System.Windows.Forms.Button();
            this.btn_ListNota = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.Btn_usuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(178, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // btn_cadCurso
            // 
            this.btn_cadCurso.Location = new System.Drawing.Point(78, 111);
            this.btn_cadCurso.Name = "btn_cadCurso";
            this.btn_cadCurso.Size = new System.Drawing.Size(279, 46);
            this.btn_cadCurso.TabIndex = 1;
            this.btn_cadCurso.Text = "Cadastro de Curso";
            this.btn_cadCurso.UseVisualStyleBackColor = true;
            this.btn_cadCurso.Click += new System.EventHandler(this.btn_cadCurso_Click);
            // 
            // btn_cadAluno
            // 
            this.btn_cadAluno.Location = new System.Drawing.Point(78, 179);
            this.btn_cadAluno.Name = "btn_cadAluno";
            this.btn_cadAluno.Size = new System.Drawing.Size(279, 46);
            this.btn_cadAluno.TabIndex = 1;
            this.btn_cadAluno.Text = "Cadastro de Aluno";
            this.btn_cadAluno.UseVisualStyleBackColor = true;
            this.btn_cadAluno.Click += new System.EventHandler(this.btn_cadAluno_Click);
            // 
            // btn_cadMateria
            // 
            this.btn_cadMateria.Location = new System.Drawing.Point(78, 246);
            this.btn_cadMateria.Name = "btn_cadMateria";
            this.btn_cadMateria.Size = new System.Drawing.Size(279, 46);
            this.btn_cadMateria.TabIndex = 1;
            this.btn_cadMateria.Text = "Cadastro de Matéria";
            this.btn_cadMateria.UseVisualStyleBackColor = true;
            this.btn_cadMateria.Click += new System.EventHandler(this.btn_cadMateria_Click);
            // 
            // btn_cadNota
            // 
            this.btn_cadNota.Enabled = false;
            this.btn_cadNota.Location = new System.Drawing.Point(78, 316);
            this.btn_cadNota.Name = "btn_cadNota";
            this.btn_cadNota.Size = new System.Drawing.Size(279, 46);
            this.btn_cadNota.TabIndex = 1;
            this.btn_cadNota.Text = "Cadastro de Nota";
            this.btn_cadNota.UseVisualStyleBackColor = true;
            // 
            // btn_ListNota
            // 
            this.btn_ListNota.Enabled = false;
            this.btn_ListNota.Location = new System.Drawing.Point(78, 385);
            this.btn_ListNota.Name = "btn_ListNota";
            this.btn_ListNota.Size = new System.Drawing.Size(279, 46);
            this.btn_ListNota.TabIndex = 1;
            this.btn_ListNota.Text = "Boletim";
            this.btn_ListNota.UseVisualStyleBackColor = true;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(78, 531);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(279, 46);
            this.btn_voltar.TabIndex = 1;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // Btn_usuario
            // 
            this.Btn_usuario.Enabled = false;
            this.Btn_usuario.Location = new System.Drawing.Point(78, 453);
            this.Btn_usuario.Name = "Btn_usuario";
            this.Btn_usuario.Size = new System.Drawing.Size(279, 46);
            this.Btn_usuario.TabIndex = 1;
            this.Btn_usuario.Text = "Cadastro de usuário";
            this.Btn_usuario.UseVisualStyleBackColor = true;
            // 
            // MenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 605);
            this.Controls.Add(this.Btn_usuario);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_ListNota);
            this.Controls.Add(this.btn_cadNota);
            this.Controls.Add(this.btn_cadMateria);
            this.Controls.Add(this.btn_cadAluno);
            this.Controls.Add(this.btn_cadCurso);
            this.Controls.Add(this.label1);
            this.Name = "MenuAdm";
            this.Text = "MenuAdm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadCurso;
        private System.Windows.Forms.Button btn_cadAluno;
        private System.Windows.Forms.Button btn_cadMateria;
        private System.Windows.Forms.Button btn_cadNota;
        private System.Windows.Forms.Button btn_ListNota;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button Btn_usuario;
    }
}
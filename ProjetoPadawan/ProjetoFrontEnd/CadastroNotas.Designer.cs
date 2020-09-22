namespace ProjetoFrontEnd
{
    partial class CadastroNotas
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
            this.txt_aluno = new System.Windows.Forms.TextBox();
            this.txt_materia = new System.Windows.Forms.TextBox();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.lbl_success = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_listarnota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aluno: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matéria: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota: ";
            // 
            // txt_aluno
            // 
            this.txt_aluno.Location = new System.Drawing.Point(107, 103);
            this.txt_aluno.Name = "txt_aluno";
            this.txt_aluno.Size = new System.Drawing.Size(247, 23);
            this.txt_aluno.TabIndex = 4;
            // 
            // txt_materia
            // 
            this.txt_materia.Location = new System.Drawing.Point(107, 143);
            this.txt_materia.Name = "txt_materia";
            this.txt_materia.Size = new System.Drawing.Size(247, 23);
            this.txt_materia.TabIndex = 4;
            // 
            // txt_nota
            // 
            this.txt_nota.Location = new System.Drawing.Point(107, 184);
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(247, 23);
            this.txt_nota.TabIndex = 4;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(158, 256);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(133, 52);
            this.btn_salvar.TabIndex = 5;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(48, 360);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(133, 52);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(285, 360);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(133, 52);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // lbl_erro
            // 
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_erro.Location = new System.Drawing.Point(208, 221);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(0, 21);
            this.lbl_erro.TabIndex = 6;
            // 
            // lbl_success
            // 
            this.lbl_success.AutoSize = true;
            this.lbl_success.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_success.ForeColor = System.Drawing.Color.Green;
            this.lbl_success.Location = new System.Drawing.Point(208, 322);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(0, 21);
            this.lbl_success.TabIndex = 7;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(285, 324);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(133, 23);
            this.txt_id.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Id: ";
            // 
            // txt_listarnota
            // 
            this.txt_listarnota.Location = new System.Drawing.Point(396, 103);
            this.txt_listarnota.Multiline = true;
            this.txt_listarnota.Name = "txt_listarnota";
            this.txt_listarnota.Size = new System.Drawing.Size(379, 205);
            this.txt_listarnota.TabIndex = 4;
            // 
            // CadastroNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 450);
            this.Controls.Add(this.txt_listarnota);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_success);
            this.Controls.Add(this.lbl_erro);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_nota);
            this.Controls.Add(this.txt_materia);
            this.Controls.Add(this.txt_aluno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroNotas";
            this.Text = "CadastroNotas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_aluno;
        private System.Windows.Forms.TextBox txt_materia;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label lbl_erro;
        private System.Windows.Forms.Label lbl_success;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_listarnota;
    }
}
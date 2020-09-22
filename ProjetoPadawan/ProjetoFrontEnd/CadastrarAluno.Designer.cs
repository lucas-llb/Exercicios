namespace ProjetoFrontEnd
{
    partial class CadastrarAluno
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.txt_datanasc = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.lbl_succes = new System.Windows.Forms.Label();
            this.txt_listaaluno = new System.Windows.Forms.TextBox();
            this.box_curso = new System.Windows.Forms.ComboBox();
            this.box_excluir = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(163, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Aluno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sobrenome: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Data de Nascimento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "CPF: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Curso: ";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(148, 120);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(249, 23);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(148, 154);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(249, 23);
            this.txt_sobrenome.TabIndex = 2;
            // 
            // txt_datanasc
            // 
            this.txt_datanasc.Location = new System.Drawing.Point(148, 186);
            this.txt_datanasc.Name = "txt_datanasc";
            this.txt_datanasc.Size = new System.Drawing.Size(249, 23);
            this.txt_datanasc.TabIndex = 2;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(148, 221);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(249, 23);
            this.txt_cpf.TabIndex = 2;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(179, 324);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(176, 51);
            this.btn_gravar.TabIndex = 3;
            this.btn_gravar.Text = "Salvar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(54, 436);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(122, 34);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(25, 53);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(122, 34);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // lbl_erro
            // 
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_erro.Location = new System.Drawing.Point(238, 296);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(0, 25);
            this.lbl_erro.TabIndex = 5;
            // 
            // lbl_succes
            // 
            this.lbl_succes.AutoSize = true;
            this.lbl_succes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_succes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_succes.Location = new System.Drawing.Point(238, 402);
            this.lbl_succes.Name = "lbl_succes";
            this.lbl_succes.Size = new System.Drawing.Size(0, 25);
            this.lbl_succes.TabIndex = 6;
            // 
            // txt_listaaluno
            // 
            this.txt_listaaluno.Location = new System.Drawing.Point(457, 120);
            this.txt_listaaluno.Multiline = true;
            this.txt_listaaluno.Name = "txt_listaaluno";
            this.txt_listaaluno.Size = new System.Drawing.Size(275, 263);
            this.txt_listaaluno.TabIndex = 7;
            // 
            // box_curso
            // 
            this.box_curso.FormattingEnabled = true;
            this.box_curso.Location = new System.Drawing.Point(148, 251);
            this.box_curso.Name = "box_curso";
            this.box_curso.Size = new System.Drawing.Size(249, 23);
            this.box_curso.TabIndex = 8;
            // 
            // box_excluir
            // 
            this.box_excluir.FormattingEnabled = true;
            this.box_excluir.Location = new System.Drawing.Point(171, 60);
            this.box_excluir.Name = "box_excluir";
            this.box_excluir.Size = new System.Drawing.Size(175, 23);
            this.box_excluir.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.box_excluir);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Location = new System.Drawing.Point(393, 402);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 97);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excluir";
            // 
            // CadastrarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 511);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.box_curso);
            this.Controls.Add(this.txt_listaaluno);
            this.Controls.Add(this.lbl_succes);
            this.Controls.Add(this.lbl_erro);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_cpf);
            this.Controls.Add(this.txt_datanasc);
            this.Controls.Add(this.txt_sobrenome);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarAluno";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CadastrarAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.TextBox txt_datanasc;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label lbl_erro;
        private System.Windows.Forms.Label lbl_succes;
        private System.Windows.Forms.TextBox txt_listaaluno;
        private System.Windows.Forms.ComboBox box_curso;
        private System.Windows.Forms.ComboBox box_excluir;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
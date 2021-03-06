﻿namespace ProjetoFrontEnd
{
    partial class CadastroMateria
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
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_datacadastro = new System.Windows.Forms.TextBox();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_listarmateria = new System.Windows.Forms.TextBox();
            this.box_situacao = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.box_excluir = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(134, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Matéria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data de Cadastro: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Situação: ";
            // 
            // txt_descricao
            // 
            this.txt_descricao.AcceptsTab = true;
            this.txt_descricao.Location = new System.Drawing.Point(158, 122);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(223, 23);
            this.txt_descricao.TabIndex = 2;
            // 
            // txt_datacadastro
            // 
            this.txt_datacadastro.AcceptsTab = true;
            this.txt_datacadastro.Location = new System.Drawing.Point(158, 155);
            this.txt_datacadastro.Name = "txt_datacadastro";
            this.txt_datacadastro.Size = new System.Drawing.Size(223, 23);
            this.txt_datacadastro.TabIndex = 2;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(143, 256);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(177, 50);
            this.btn_gravar.TabIndex = 3;
            this.btn_gravar.Text = "Salvar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(6, 35);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(177, 50);
            this.btn_excluir.TabIndex = 3;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(49, 388);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(177, 50);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nome: ";
            // 
            // txt_nome
            // 
            this.txt_nome.AcceptsTab = true;
            this.txt_nome.Location = new System.Drawing.Point(158, 90);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(223, 23);
            this.txt_nome.TabIndex = 2;
            // 
            // txt_listarmateria
            // 
            this.txt_listarmateria.Location = new System.Drawing.Point(425, 90);
            this.txt_listarmateria.Multiline = true;
            this.txt_listarmateria.Name = "txt_listarmateria";
            this.txt_listarmateria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_listarmateria.Size = new System.Drawing.Size(265, 257);
            this.txt_listarmateria.TabIndex = 2;
            // 
            // box_situacao
            // 
            this.box_situacao.FormattingEnabled = true;
            this.box_situacao.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.box_situacao.Location = new System.Drawing.Point(158, 187);
            this.box_situacao.Name = "box_situacao";
            this.box_situacao.Size = new System.Drawing.Size(223, 23);
            this.box_situacao.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.box_excluir);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Location = new System.Drawing.Point(356, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 114);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Excluir";
            // 
            // box_excluir
            // 
            this.box_excluir.FormattingEnabled = true;
            this.box_excluir.Location = new System.Drawing.Point(194, 50);
            this.box_excluir.Name = "box_excluir";
            this.box_excluir.Size = new System.Drawing.Size(189, 23);
            this.box_excluir.TabIndex = 4;
            // 
            // CadastroMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 484);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.box_situacao);
            this.Controls.Add(this.txt_listarmateria);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.txt_datacadastro);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroMateria";
            this.Text = "CadastroMateria";
            this.Load += new System.EventHandler(this.CadastroMateria_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_datacadastro;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_listarmateria;
        private System.Windows.Forms.ComboBox box_situacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox box_excluir;
    }
}
﻿namespace ProjetoFrontEnd
{
    partial class CadastrarCurso
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
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_materia = new System.Windows.Forms.TextBox();
            this.txt_situacao = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.lbl_erro = new System.Windows.Forms.Label();
            this.lbl_success = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(158, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Matéria: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Situação: ";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(110, 111);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(237, 23);
            this.txt_nome.TabIndex = 3;
            // 
            // txt_materia
            // 
            this.txt_materia.Location = new System.Drawing.Point(110, 146);
            this.txt_materia.Name = "txt_materia";
            this.txt_materia.Size = new System.Drawing.Size(237, 23);
            this.txt_materia.TabIndex = 3;
            // 
            // txt_situacao
            // 
            this.txt_situacao.Location = new System.Drawing.Point(110, 177);
            this.txt_situacao.Name = "txt_situacao";
            this.txt_situacao.Size = new System.Drawing.Size(237, 23);
            this.txt_situacao.TabIndex = 3;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(186, 245);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(148, 54);
            this.btn_salvar.TabIndex = 4;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(327, 392);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(148, 54);
            this.btn_excluir.TabIndex = 4;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(58, 392);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(148, 54);
            this.btn_voltar.TabIndex = 4;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            // 
            // lbl_erro
            // 
            this.lbl_erro.AutoSize = true;
            this.lbl_erro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_erro.ForeColor = System.Drawing.Color.Red;
            this.lbl_erro.Location = new System.Drawing.Point(239, 218);
            this.lbl_erro.Name = "lbl_erro";
            this.lbl_erro.Size = new System.Drawing.Size(0, 21);
            this.lbl_erro.TabIndex = 5;
            // 
            // lbl_success
            // 
            this.lbl_success.AutoSize = true;
            this.lbl_success.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_success.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_success.Location = new System.Drawing.Point(239, 323);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(0, 21);
            this.lbl_success.TabIndex = 6;
            // 
            // CadastrarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 494);
            this.Controls.Add(this.lbl_success);
            this.Controls.Add(this.lbl_erro);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_situacao);
            this.Controls.Add(this.txt_materia);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarCurso";
            this.Text = "CadastrarCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_materia;
        private System.Windows.Forms.TextBox txt_situacao;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.Label lbl_erro;
        private System.Windows.Forms.Label lbl_success;
    }
}
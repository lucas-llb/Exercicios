namespace ProjetoFrontEnd
{
    partial class ListarNotas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lista = new System.Windows.Forms.TextBox();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.box_aluno = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(266, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boletim";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aluno: ";
            // 
            // txt_lista
            // 
            this.txt_lista.Location = new System.Drawing.Point(132, 171);
            this.txt_lista.Multiline = true;
            this.txt_lista.Name = "txt_lista";
            this.txt_lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_lista.Size = new System.Drawing.Size(328, 229);
            this.txt_lista.TabIndex = 2;
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(383, 460);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(126, 47);
            this.btn_listar.TabIndex = 3;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.btn_listar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.Location = new System.Drawing.Point(80, 460);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(126, 47);
            this.btn_voltar.TabIndex = 3;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = true;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // box_aluno
            // 
            this.box_aluno.FormattingEnabled = true;
            this.box_aluno.Location = new System.Drawing.Point(132, 92);
            this.box_aluno.Name = "box_aluno";
            this.box_aluno.Size = new System.Drawing.Size(328, 23);
            this.box_aluno.TabIndex = 4;
            // 
            // ListarNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 540);
            this.Controls.Add(this.box_aluno);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.txt_lista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListarNotas";
            this.Text = "ListarNotas";
            this.Load += new System.EventHandler(this.ListarNotas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lista;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_voltar;
        private System.Windows.Forms.ComboBox box_aluno;
    }
}
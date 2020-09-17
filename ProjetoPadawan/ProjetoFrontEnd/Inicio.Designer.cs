namespace ProjetoFrontEnd
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_aluno = new System.Windows.Forms.Button();
            this.btn_professor = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(148, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(137, 29);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Autenticação";
            // 
            // btn_aluno
            // 
            this.btn_aluno.Location = new System.Drawing.Point(135, 136);
            this.btn_aluno.Name = "btn_aluno";
            this.btn_aluno.Size = new System.Drawing.Size(171, 59);
            this.btn_aluno.TabIndex = 1;
            this.btn_aluno.Text = "Aluno";
            this.btn_aluno.UseVisualStyleBackColor = true;
            this.btn_aluno.Click += new System.EventHandler(this.btn_aluno_Click);
            // 
            // btn_professor
            // 
            this.btn_professor.Location = new System.Drawing.Point(135, 232);
            this.btn_professor.Name = "btn_professor";
            this.btn_professor.Size = new System.Drawing.Size(171, 59);
            this.btn_professor.TabIndex = 1;
            this.btn_professor.Text = "Professor";
            this.btn_professor.UseVisualStyleBackColor = true;
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(135, 329);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(171, 59);
            this.btn_admin.TabIndex = 1;
            this.btn_admin.Text = "Administrador";
            this.btn_admin.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 525);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_professor);
            this.Controls.Add(this.btn_aluno);
            this.Controls.Add(this.lbl1);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_aluno;
        private System.Windows.Forms.Button btn_professor;
        private System.Windows.Forms.Button btn_admin;
    }
}


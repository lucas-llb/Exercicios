namespace RaidSolution
{
    partial class Form1
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
            this.btn_registraheroi = new System.Windows.Forms.Button();
            this.btn_comparaheroi = new System.Windows.Forms.Button();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_registraheroi
            // 
            this.btn_registraheroi.Location = new System.Drawing.Point(73, 72);
            this.btn_registraheroi.Name = "btn_registraheroi";
            this.btn_registraheroi.Size = new System.Drawing.Size(102, 42);
            this.btn_registraheroi.TabIndex = 0;
            this.btn_registraheroi.Text = "Registrar Heroi";
            this.btn_registraheroi.UseVisualStyleBackColor = true;
            // 
            // btn_comparaheroi
            // 
            this.btn_comparaheroi.Location = new System.Drawing.Point(73, 148);
            this.btn_comparaheroi.Name = "btn_comparaheroi";
            this.btn_comparaheroi.Size = new System.Drawing.Size(102, 42);
            this.btn_comparaheroi.TabIndex = 1;
            this.btn_comparaheroi.Text = "Comparar Herois";
            this.btn_comparaheroi.UseVisualStyleBackColor = true;
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(73, 221);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(102, 42);
            this.btn_listar.TabIndex = 2;
            this.btn_listar.Text = "Listar Herois";
            this.btn_listar.UseVisualStyleBackColor = true;
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(73, 292);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(102, 42);
            this.btn_remover.TabIndex = 3;
            this.btn_remover.Text = "Remover Herois";
            this.btn_remover.UseVisualStyleBackColor = true;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(340, 370);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(102, 42);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.btn_comparaheroi);
            this.Controls.Add(this.btn_registraheroi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_registraheroi;
        private System.Windows.Forms.Button btn_comparaheroi;
        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_sair;
    }
}


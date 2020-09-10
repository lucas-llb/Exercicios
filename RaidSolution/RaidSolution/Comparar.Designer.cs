namespace RaidSolution
{
    partial class Comparar
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
            this.lista_heros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lista_heros
            // 
            this.lista_heros.FormattingEnabled = true;
            this.lista_heros.Location = new System.Drawing.Point(537, 41);
            this.lista_heros.Name = "lista_heros";
            this.lista_heros.Size = new System.Drawing.Size(188, 225);
            this.lista_heros.TabIndex = 0;
            // 
            // Comparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lista_heros);
            this.Name = "Comparar";
            this.Text = "Comparar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lista_heros;
    }
}
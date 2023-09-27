namespace DoeComPaixao.Telas
{
    partial class TelaCategoria
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
            this.GpCategorias = new System.Windows.Forms.GroupBox();
            this.LblIdCategorias = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.LblNomeCategoria = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GpCategorias.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpCategorias
            // 
            this.GpCategorias.Controls.Add(this.textBox1);
            this.GpCategorias.Controls.Add(this.LblNomeCategoria);
            this.GpCategorias.Controls.Add(this.ID);
            this.GpCategorias.Controls.Add(this.LblIdCategorias);
            this.GpCategorias.Location = new System.Drawing.Point(12, 12);
            this.GpCategorias.Name = "GpCategorias";
            this.GpCategorias.Size = new System.Drawing.Size(200, 426);
            this.GpCategorias.TabIndex = 0;
            this.GpCategorias.TabStop = false;
            this.GpCategorias.Text = "Categorias";
            // 
            // LblIdCategorias
            // 
            this.LblIdCategorias.Location = new System.Drawing.Point(6, 67);
            this.LblIdCategorias.Name = "LblIdCategorias";
            this.LblIdCategorias.Size = new System.Drawing.Size(100, 20);
            this.LblIdCategorias.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(7, 48);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // LblNomeCategoria
            // 
            this.LblNomeCategoria.AutoSize = true;
            this.LblNomeCategoria.Location = new System.Drawing.Point(7, 124);
            this.LblNomeCategoria.Name = "LblNomeCategoria";
            this.LblNomeCategoria.Size = new System.Drawing.Size(98, 13);
            this.LblNomeCategoria.TabIndex = 2;
            this.LblNomeCategoria.Text = "Nome da Categoria";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // TelaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GpCategorias);
            this.Name = "TelaCategoria";
            this.Text = "TelaCategoria";
            this.GpCategorias.ResumeLayout(false);
            this.GpCategorias.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpCategorias;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LblNomeCategoria;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox LblIdCategorias;
    }
}
namespace DoeComPaixao.Telas
{
    //partial class TelaCategoria
    //{
    //    /// <summary>
    //    /// Required designer variable.
    //    /// </summary>
    //    private System.ComponentModel.IContainer components = null;

    //    /// <summary>
    //    /// Clean up any resources being used.
    //    /// </summary>
    //    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    //    protected override void Dispose(bool disposing)
    //    {
    //        if (disposing && (components != null))
    //        {
    //            components.Dispose();
    //        }
    //        base.Dispose(disposing);
    //    }

    //    #region Windows Form Designer generated code

    //    /// <summary>
    //    /// Required method for Designer support - do not modify
    //    /// the contents of this method with the code editor.
    //    /// </summary>
    //    private void InitializeComponent()
    //    {
    //        this.GpCategorias = new System.Windows.Forms.GroupBox();
    //        this.BtnBuscar = new System.Windows.Forms.Button();
    //        this.BtnAlterar = new System.Windows.Forms.Button();
    //        this.BtnAdicionar = new System.Windows.Forms.Button();
    //        this.BtnExcluir = new System.Windows.Forms.Button();
    //        this.TxtNomeCategorias = new System.Windows.Forms.TextBox();
    //        this.LblNomeCategoria = new System.Windows.Forms.Label();
    //        this.ID = new System.Windows.Forms.Label();
    //        this.TxtIdCategorias = new System.Windows.Forms.TextBox();
    //        this.pictureBox2 = new System.Windows.Forms.PictureBox();
    //        this.groupBox1 = new System.Windows.Forms.GroupBox();
    //        this.label1 = new System.Windows.Forms.Label();
    //        this.CbbCategorias = new System.Windows.Forms.ComboBox();
    //        this.TxtBuscarCategorias = new System.Windows.Forms.TextBox();
    //        this.DgvCategoria = new System.Windows.Forms.DataGridView();
    //        this.GpCategorias.SuspendLayout();
    //        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
    //        this.groupBox1.SuspendLayout();
    //        ((System.ComponentModel.ISupportInitialize)(this.DgvCategoria)).BeginInit();
    //        this.SuspendLayout();
    //        // 
    //        // GpCategorias
    //        // 
    //        this.GpCategorias.Controls.Add(this.pictureBox2);
    //        this.GpCategorias.Controls.Add(this.BtnAlterar);
    //        this.GpCategorias.Controls.Add(this.BtnAdicionar);
    //        this.GpCategorias.Controls.Add(this.BtnExcluir);
    //        this.GpCategorias.Controls.Add(this.TxtNomeCategorias);
    //        this.GpCategorias.Controls.Add(this.LblNomeCategoria);
    //        this.GpCategorias.Controls.Add(this.ID);
    //        this.GpCategorias.Controls.Add(this.TxtIdCategorias);
    //        this.GpCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.GpCategorias.Location = new System.Drawing.Point(12, -2);
    //        this.GpCategorias.Name = "GpCategorias";
    //        this.GpCategorias.Size = new System.Drawing.Size(700, 309);
    //        this.GpCategorias.TabIndex = 0;
    //        this.GpCategorias.TabStop = false;
    //        this.GpCategorias.Text = "Categorias";
    //        // 
    //        // BtnBuscar
    //        // 
    //        this.BtnBuscar.Location = new System.Drawing.Point(552, 66);
    //        this.BtnBuscar.Name = "BtnBuscar";
    //        this.BtnBuscar.Size = new System.Drawing.Size(140, 88);
    //        this.BtnBuscar.TabIndex = 7;
    //        this.BtnBuscar.Text = "Buscar";
    //        this.BtnBuscar.UseVisualStyleBackColor = true;
    //        // 
    //        // BtnAlterar
    //        // 
    //        this.BtnAlterar.Location = new System.Drawing.Point(154, 228);
    //        this.BtnAlterar.Name = "BtnAlterar";
    //        this.BtnAlterar.Size = new System.Drawing.Size(145, 42);
    //        this.BtnAlterar.TabIndex = 6;
    //        this.BtnAlterar.Text = "Alterar";
    //        this.BtnAlterar.UseVisualStyleBackColor = true;
    //        // 
    //        // BtnAdicionar
    //        // 
    //        this.BtnAdicionar.Location = new System.Drawing.Point(11, 228);
    //        this.BtnAdicionar.Name = "BtnAdicionar";
    //        this.BtnAdicionar.Size = new System.Drawing.Size(127, 42);
    //        this.BtnAdicionar.TabIndex = 5;
    //        this.BtnAdicionar.Text = "Adicionar";
    //        this.BtnAdicionar.UseVisualStyleBackColor = true;
    //        this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
    //        // 
    //        // BtnExcluir
    //        // 
    //        this.BtnExcluir.Location = new System.Drawing.Point(552, 228);
    //        this.BtnExcluir.Name = "BtnExcluir";
    //        this.BtnExcluir.Size = new System.Drawing.Size(140, 42);
    //        this.BtnExcluir.TabIndex = 4;
    //        this.BtnExcluir.Text = "Excluir";
    //        this.BtnExcluir.UseVisualStyleBackColor = true;
    //        // 
    //        // TxtNomeCategorias
    //        // 
    //        this.TxtNomeCategorias.Location = new System.Drawing.Point(6, 155);
    //        this.TxtNomeCategorias.Name = "TxtNomeCategorias";
    //        this.TxtNomeCategorias.Size = new System.Drawing.Size(170, 31);
    //        this.TxtNomeCategorias.TabIndex = 3;
    //        // 
    //        // LblNomeCategoria
    //        // 
    //        this.LblNomeCategoria.AutoSize = true;
    //        this.LblNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.LblNomeCategoria.Location = new System.Drawing.Point(3, 127);
    //        this.LblNomeCategoria.Name = "LblNomeCategoria";
    //        this.LblNomeCategoria.Size = new System.Drawing.Size(173, 24);
    //        this.LblNomeCategoria.TabIndex = 2;
    //        this.LblNomeCategoria.Text = "Nome da Categoria";
    //        // 
    //        // ID
    //        // 
    //        this.ID.AutoSize = true;
    //        this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.ID.Location = new System.Drawing.Point(6, 31);
    //        this.ID.Name = "ID";
    //        this.ID.Size = new System.Drawing.Size(27, 24);
    //        this.ID.TabIndex = 1;
    //        this.ID.Text = "ID";
    //        // 
    //        // TxtIdCategorias
    //        // 
    //        this.TxtIdCategorias.Location = new System.Drawing.Point(6, 67);
    //        this.TxtIdCategorias.Name = "TxtIdCategorias";
    //        this.TxtIdCategorias.Size = new System.Drawing.Size(140, 31);
    //        this.TxtIdCategorias.TabIndex = 0;
    //        // 
    //        // pictureBox2
    //        // 
    //        this.pictureBox2.Image = global::DoeComPaixao.Properties.Resources.LogoDoe;
    //        this.pictureBox2.Location = new System.Drawing.Point(422, 19);
    //        this.pictureBox2.Name = "pictureBox2";
    //        this.pictureBox2.Size = new System.Drawing.Size(272, 144);
    //        this.pictureBox2.TabIndex = 16;
    //        this.pictureBox2.TabStop = false;
    //        // 
    //        // groupBox1
    //        // 
    //        this.groupBox1.Controls.Add(this.TxtBuscarCategorias);
    //        this.groupBox1.Controls.Add(this.CbbCategorias);
    //        this.groupBox1.Controls.Add(this.label1);
    //        this.groupBox1.Controls.Add(this.BtnBuscar);
    //        this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.groupBox1.Location = new System.Drawing.Point(12, 313);
    //        this.groupBox1.Name = "groupBox1";
    //        this.groupBox1.Size = new System.Drawing.Size(700, 183);
    //        this.groupBox1.TabIndex = 17;
    //        this.groupBox1.TabStop = false;
    //        this.groupBox1.Text = "Painel de Busca";
    //        // 
    //        // label1
    //        // 
    //        this.label1.AutoSize = true;
    //        this.label1.Location = new System.Drawing.Point(16, 38);
    //        this.label1.Name = "label1";
    //        this.label1.Size = new System.Drawing.Size(122, 25);
    //        this.label1.TabIndex = 0;
    //        this.label1.Text = "Buscar por:";
    //        // 
    //        // CbbCategorias
    //        // 
    //        this.CbbCategorias.FormattingEnabled = true;
    //        this.CbbCategorias.Location = new System.Drawing.Point(21, 66);
    //        this.CbbCategorias.Name = "CbbCategorias";
    //        this.CbbCategorias.Size = new System.Drawing.Size(500, 33);
    //        this.CbbCategorias.TabIndex = 8;
    //        // 
    //        // TxtBuscarCategorias
    //        // 
    //        this.TxtBuscarCategorias.Location = new System.Drawing.Point(21, 123);
    //        this.TxtBuscarCategorias.Name = "TxtBuscarCategorias";
    //        this.TxtBuscarCategorias.Size = new System.Drawing.Size(500, 31);
    //        this.TxtBuscarCategorias.TabIndex = 9;
    //        // 
    //        // DgvCategoria
    //        // 
    //        this.DgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    //        this.DgvCategoria.Location = new System.Drawing.Point(718, 12);
    //        this.DgvCategoria.Name = "DgvCategoria";
    //        this.DgvCategoria.Size = new System.Drawing.Size(372, 484);
    //        this.DgvCategoria.TabIndex = 18;
    //        // 
    //        // TelaCategoria
    //        // 
    //        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        this.ClientSize = new System.Drawing.Size(1102, 505);
    //        this.Controls.Add(this.DgvCategoria);
    //        this.Controls.Add(this.groupBox1);
    //        this.Controls.Add(this.GpCategorias);
    //        this.Name = "TelaCategoria";
    //        this.Text = "TelaCategoria";
    //        this.GpCategorias.ResumeLayout(false);
    //        this.GpCategorias.PerformLayout();
    //        ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
    //        this.groupBox1.ResumeLayout(false);
    //        this.groupBox1.PerformLayout();
    //        ((System.ComponentModel.ISupportInitialize)(this.DgvCategoria)).EndInit();
    //        this.ResumeLayout(false);

    //    }

    //    #endregion

    //    private System.Windows.Forms.GroupBox GpCategorias;
    //    private System.Windows.Forms.TextBox TxtNomeCategorias;
    //    private System.Windows.Forms.Label LblNomeCategoria;
    //    private System.Windows.Forms.Label ID;
    //    private System.Windows.Forms.TextBox TxtIdCategorias;
    //    private System.Windows.Forms.Button BtnBuscar;
    //    private System.Windows.Forms.Button BtnAlterar;
    //    private System.Windows.Forms.Button BtnAdicionar;
    //    private System.Windows.Forms.Button BtnExcluir;
    //    private System.Windows.Forms.PictureBox pictureBox2;
    //    private System.Windows.Forms.GroupBox groupBox1;
    //    private System.Windows.Forms.Label label1;
    //    private System.Windows.Forms.ComboBox CbbCategorias;
    //    private System.Windows.Forms.TextBox TxtBuscarCategorias;
    //    private System.Windows.Forms.DataGridView DgvCategoria;
    //}
}
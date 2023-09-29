namespace DoeComPaixao.Telas
{
    //partial class Anuncio
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
    //        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anuncio));
    //        this.PicLogo = new System.Windows.Forms.PictureBox();
    //        this.Cadastrar = new System.Windows.Forms.Button();
    //        this.button2 = new System.Windows.Forms.Button();
    //        this.button3 = new System.Windows.Forms.Button();
    //        this.button4 = new System.Windows.Forms.Button();
    //        this.GboxAnuncio = new System.Windows.Forms.GroupBox();
    //        this.CodCliente = new System.Windows.Forms.TextBox();
    //        this.CodAnuncio = new System.Windows.Forms.TextBox();
    //        this.LblCodCliente = new System.Windows.Forms.Label();
    //        this.LblCodAnuncio = new System.Windows.Forms.Label();
    //        this.comboBox1 = new System.Windows.Forms.ComboBox();
    //        this.LblCondicoes = new System.Windows.Forms.Label();
    //        this.CbxCategoria = new System.Windows.Forms.ComboBox();
    //        this.LblCategoria = new System.Windows.Forms.Label();
    //        this.Titulo = new System.Windows.Forms.TextBox();
    //        this.LblTítulo = new System.Windows.Forms.Label();
    //        this.DgvAnuncios = new System.Windows.Forms.GroupBox();
    //        ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
    //        this.GboxAnuncio.SuspendLayout();
    //        this.SuspendLayout();
    //        // 
    //        // PicLogo
    //        // 
    //        this.PicLogo.BackColor = System.Drawing.Color.Transparent;
    //        this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
    //        this.PicLogo.Location = new System.Drawing.Point(521, 94);
    //        this.PicLogo.Name = "PicLogo";
    //        this.PicLogo.Size = new System.Drawing.Size(278, 70);
    //        this.PicLogo.TabIndex = 3;
    //        this.PicLogo.TabStop = false;
    //        // 
    //        // Cadastrar
    //        // 
    //        this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.Cadastrar.Location = new System.Drawing.Point(11, 248);
    //        this.Cadastrar.Name = "Cadastrar";
    //        this.Cadastrar.Size = new System.Drawing.Size(153, 41);
    //        this.Cadastrar.TabIndex = 5;
    //        this.Cadastrar.Text = "Cadastrar";
    //        this.Cadastrar.UseVisualStyleBackColor = true;
    //        // 
    //        // button2
    //        // 
    //        this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.button2.Location = new System.Drawing.Point(206, 248);
    //        this.button2.Name = "button2";
    //        this.button2.Size = new System.Drawing.Size(153, 41);
    //        this.button2.TabIndex = 6;
    //        this.button2.Text = "Consultar";
    //        this.button2.UseVisualStyleBackColor = true;
    //        // 
    //        // button3
    //        // 
    //        this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.button3.Location = new System.Drawing.Point(399, 248);
    //        this.button3.Name = "button3";
    //        this.button3.Size = new System.Drawing.Size(153, 41);
    //        this.button3.TabIndex = 7;
    //        this.button3.Text = "Alterar";
    //        this.button3.UseVisualStyleBackColor = true;
    //        // 
    //        // button4
    //        // 
    //        this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.button4.Location = new System.Drawing.Point(597, 248);
    //        this.button4.Name = "button4";
    //        this.button4.Size = new System.Drawing.Size(153, 41);
    //        this.button4.TabIndex = 8;
    //        this.button4.Text = "Excluir";
    //        this.button4.UseVisualStyleBackColor = true;
    //        // 
    //        // GboxAnuncio
    //        // 
    //        this.GboxAnuncio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
    //        this.GboxAnuncio.Controls.Add(this.CodCliente);
    //        this.GboxAnuncio.Controls.Add(this.CodAnuncio);
    //        this.GboxAnuncio.Controls.Add(this.LblCodCliente);
    //        this.GboxAnuncio.Controls.Add(this.LblCodAnuncio);
    //        this.GboxAnuncio.Controls.Add(this.comboBox1);
    //        this.GboxAnuncio.Controls.Add(this.LblCondicoes);
    //        this.GboxAnuncio.Controls.Add(this.CbxCategoria);
    //        this.GboxAnuncio.Controls.Add(this.LblCategoria);
    //        this.GboxAnuncio.Controls.Add(this.Titulo);
    //        this.GboxAnuncio.Controls.Add(this.LblTítulo);
    //        this.GboxAnuncio.Controls.Add(this.Cadastrar);
    //        this.GboxAnuncio.Controls.Add(this.button4);
    //        this.GboxAnuncio.Controls.Add(this.PicLogo);
    //        this.GboxAnuncio.Controls.Add(this.button2);
    //        this.GboxAnuncio.Controls.Add(this.button3);
    //        this.GboxAnuncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    //        this.GboxAnuncio.Location = new System.Drawing.Point(42, 28);
    //        this.GboxAnuncio.Name = "GboxAnuncio";
    //        this.GboxAnuncio.Size = new System.Drawing.Size(805, 309);
    //        this.GboxAnuncio.TabIndex = 9;
    //        this.GboxAnuncio.TabStop = false;
    //        this.GboxAnuncio.Text = "Anúncio";
    //        // 
    //        // CodCliente
    //        // 
    //        this.CodCliente.Location = new System.Drawing.Point(215, 75);
    //        this.CodCliente.Name = "CodCliente";
    //        this.CodCliente.Size = new System.Drawing.Size(273, 31);
    //        this.CodCliente.TabIndex = 18;
    //        // 
    //        // CodAnuncio
    //        // 
    //        this.CodAnuncio.Location = new System.Drawing.Point(215, 39);
    //        this.CodAnuncio.Name = "CodAnuncio";
    //        this.CodAnuncio.Size = new System.Drawing.Size(273, 31);
    //        this.CodAnuncio.TabIndex = 17;
    //        // 
    //        // LblCodCliente
    //        // 
    //        this.LblCodCliente.AutoSize = true;
    //        this.LblCodCliente.Location = new System.Drawing.Point(15, 75);
    //        this.LblCodCliente.Name = "LblCodCliente";
    //        this.LblCodCliente.Size = new System.Drawing.Size(189, 25);
    //        this.LblCodCliente.TabIndex = 16;
    //        this.LblCodCliente.Text = "Código do Cliente:";
    //        // 
    //        // LblCodAnuncio
    //        // 
    //        this.LblCodAnuncio.AutoSize = true;
    //        this.LblCodAnuncio.Location = new System.Drawing.Point(15, 39);
    //        this.LblCodAnuncio.Name = "LblCodAnuncio";
    //        this.LblCodAnuncio.Size = new System.Drawing.Size(200, 25);
    //        this.LblCodAnuncio.TabIndex = 15;
    //        this.LblCodAnuncio.Text = "Código do Anúncio:";
    //        // 
    //        // comboBox1
    //        // 
    //        this.comboBox1.FormattingEnabled = true;
    //        this.comboBox1.Location = new System.Drawing.Point(215, 152);
    //        this.comboBox1.Name = "comboBox1";
    //        this.comboBox1.Size = new System.Drawing.Size(273, 33);
    //        this.comboBox1.TabIndex = 14;
    //        // 
    //        // LblCondicoes
    //        // 
    //        this.LblCondicoes.AutoSize = true;
    //        this.LblCondicoes.Location = new System.Drawing.Point(15, 153);
    //        this.LblCondicoes.Name = "LblCondicoes";
    //        this.LblCondicoes.Size = new System.Drawing.Size(120, 25);
    //        this.LblCondicoes.TabIndex = 13;
    //        this.LblCondicoes.Text = "Condições:";
    //        // 
    //        // CbxCategoria
    //        // 
    //        this.CbxCategoria.FormattingEnabled = true;
    //        this.CbxCategoria.Location = new System.Drawing.Point(215, 113);
    //        this.CbxCategoria.Name = "CbxCategoria";
    //        this.CbxCategoria.Size = new System.Drawing.Size(273, 33);
    //        this.CbxCategoria.TabIndex = 12;
    //        // 
    //        // LblCategoria
    //        // 
    //        this.LblCategoria.AutoSize = true;
    //        this.LblCategoria.Location = new System.Drawing.Point(15, 116);
    //        this.LblCategoria.Name = "LblCategoria";
    //        this.LblCategoria.Size = new System.Drawing.Size(111, 25);
    //        this.LblCategoria.TabIndex = 11;
    //        this.LblCategoria.Text = "Categoria:";
    //        // 
    //        // Titulo
    //        // 
    //        this.Titulo.Location = new System.Drawing.Point(215, 191);
    //        this.Titulo.Name = "Titulo";
    //        this.Titulo.Size = new System.Drawing.Size(273, 31);
    //        this.Titulo.TabIndex = 10;
    //        // 
    //        // LblTítulo
    //        // 
    //        this.LblTítulo.AutoSize = true;
    //        this.LblTítulo.Location = new System.Drawing.Point(15, 191);
    //        this.LblTítulo.Name = "LblTítulo";
    //        this.LblTítulo.Size = new System.Drawing.Size(71, 25);
    //        this.LblTítulo.TabIndex = 9;
    //        this.LblTítulo.Text = "Título:";
    //        // 
    //        // DgvAnuncios
    //        // 
    //        this.DgvAnuncios.Location = new System.Drawing.Point(42, 382);
    //        this.DgvAnuncios.Name = "DgvAnuncios";
    //        this.DgvAnuncios.Size = new System.Drawing.Size(799, 191);
    //        this.DgvAnuncios.TabIndex = 10;
    //        this.DgvAnuncios.TabStop = false;
    //        // 
    //        // Anuncio
    //        // 
    //        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    //        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    //        this.BackColor = System.Drawing.SystemColors.Info;
    //        this.ClientSize = new System.Drawing.Size(907, 604);
    //        this.Controls.Add(this.DgvAnuncios);
    //        this.Controls.Add(this.GboxAnuncio);
    //        this.Name = "Anuncio";
    //        this.Text = "Anuncio";
    //        ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
    //        this.GboxAnuncio.ResumeLayout(false);
    //        this.GboxAnuncio.PerformLayout();
    //        this.ResumeLayout(false);

    //    }

    //    #endregion
    //    private System.Windows.Forms.PictureBox PicLogo;
    //    private System.Windows.Forms.Button Cadastrar;
    //    private System.Windows.Forms.Button button2;
    //    private System.Windows.Forms.Button button3;
    //    private System.Windows.Forms.Button button4;
    //    private System.Windows.Forms.GroupBox GboxAnuncio;
    //    private System.Windows.Forms.Label LblTítulo;
    //    private System.Windows.Forms.TextBox Titulo;
    //    private System.Windows.Forms.ComboBox CbxCategoria;
    //    private System.Windows.Forms.Label LblCategoria;
    //    private System.Windows.Forms.ComboBox comboBox1;
    //    private System.Windows.Forms.Label LblCondicoes;
    //    private System.Windows.Forms.Label LblCodAnuncio;
    //    private System.Windows.Forms.Label LblCodCliente;
    //    private System.Windows.Forms.TextBox CodCliente;
    //    private System.Windows.Forms.TextBox CodAnuncio;
    //    private System.Windows.Forms.GroupBox DgvAnuncios;
    //}
}
namespace DoeComPaixao
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.GpbLogin = new System.Windows.Forms.GroupBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.ChkVisualizarSenha = new System.Windows.Forms.CheckBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.StsBarraStatus = new System.Windows.Forms.StatusStrip();
            this.StlData = new System.Windows.Forms.ToolStripStatusLabel();
            this.TmrRelogio = new System.Windows.Forms.Timer(this.components);
            this.SslStatusConexao = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssStatusConexao = new System.Windows.Forms.ToolStripStatusLabel();
            this.GpbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.StsBarraStatus.SuspendLayout();
            this.SslStatusConexao.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpbLogin
            // 
            this.GpbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.GpbLogin.Controls.Add(this.SslStatusConexao);
            this.GpbLogin.Controls.Add(this.ChkVisualizarSenha);
            this.GpbLogin.Controls.Add(this.TxtSenha);
            this.GpbLogin.Controls.Add(this.LblSenha);
            this.GpbLogin.Controls.Add(this.TxtEmail);
            this.GpbLogin.Controls.Add(this.LblEmail);
            this.GpbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GpbLogin.Location = new System.Drawing.Point(12, 99);
            this.GpbLogin.Name = "GpbLogin";
            this.GpbLogin.Size = new System.Drawing.Size(356, 177);
            this.GpbLogin.TabIndex = 1;
            this.GpbLogin.TabStop = false;
            this.GpbLogin.Text = " ------------ Faça seu Login ------------";
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnLimpar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.BtnLimpar.Location = new System.Drawing.Point(199, 282);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(100, 30);
            this.BtnLimpar.TabIndex = 7;
            this.BtnLimpar.Text = "LIMPAR";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.BtnLogin.Location = new System.Drawing.Point(82, 282);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(100, 30);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "LOGIN";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // ChkVisualizarSenha
            // 
            this.ChkVisualizarSenha.AutoSize = true;
            this.ChkVisualizarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkVisualizarSenha.Location = new System.Drawing.Point(124, 119);
            this.ChkVisualizarSenha.Name = "ChkVisualizarSenha";
            this.ChkVisualizarSenha.Size = new System.Drawing.Size(108, 16);
            this.ChkVisualizarSenha.TabIndex = 5;
            this.ChkVisualizarSenha.Text = "Visualizar senha";
            this.ChkVisualizarSenha.UseVisualStyleBackColor = true;
            this.ChkVisualizarSenha.CheckedChanged += new System.EventHandler(this.CkbVisualizarSenha_CheckedChanged);
            this.ChkVisualizarSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChkVisualizarSenha_KeyPress);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.Location = new System.Drawing.Point(18, 112);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Size = new System.Drawing.Size(100, 24);
            this.TxtSenha.TabIndex = 4;
            this.TxtSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSenha.UseSystemPasswordChar = true;
            this.TxtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSenha_KeyPress);
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(14, 91);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(154, 18);
            this.LblSenha.TabIndex = 3;
            this.LblSenha.Text = "Informe sua Senha ";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.TxtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TxtEmail.Location = new System.Drawing.Point(18, 60);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(242, 24);
            this.TxtEmail.TabIndex = 2;
            this.TxtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(15, 41);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(155, 18);
            this.LblEmail.TabIndex = 2;
            this.LblEmail.Text = "Informe seu E-mail ";
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(56, 22);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(254, 59);
            this.PicLogo.TabIndex = 2;
            this.PicLogo.TabStop = false;
            // 
            // StsBarraStatus
            // 
            this.StsBarraStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StsBarraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StlData});
            this.StsBarraStatus.Location = new System.Drawing.Point(0, 335);
            this.StsBarraStatus.Name = "StsBarraStatus";
            this.StsBarraStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StsBarraStatus.Size = new System.Drawing.Size(380, 22);
            this.StsBarraStatus.TabIndex = 6;
            // 
            // StlData
            // 
            this.StlData.Name = "StlData";
            this.StlData.Size = new System.Drawing.Size(220, 17);
            this.StlData.Text = "Quarta-feira, 20 de Setembro de 2023";
            // 
            // TmrRelogio
            // 
            this.TmrRelogio.Tick += new System.EventHandler(this.TmrRelogio_Tick);
            // 
            // SslStatusConexao
            // 
            this.SslStatusConexao.BackColor = System.Drawing.Color.Transparent;
            this.SslStatusConexao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SslStatusConexao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.TssStatusConexao});
            this.SslStatusConexao.Location = new System.Drawing.Point(3, 152);
            this.SslStatusConexao.Name = "SslStatusConexao";
            this.SslStatusConexao.Size = new System.Drawing.Size(350, 22);
            this.SslStatusConexao.TabIndex = 9;
            this.SslStatusConexao.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // TssStatusConexao
            // 
            this.TssStatusConexao.Name = "TssStatusConexao";
            this.TssStatusConexao.Size = new System.Drawing.Size(93, 17);
            this.TssStatusConexao.Text = "Status Conexão";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(380, 357);
            this.Controls.Add(this.StsBarraStatus);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.PicLogo);
            this.Controls.Add(this.GpbLogin);
            this.Controls.Add(this.BtnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.GpbLogin.ResumeLayout(false);
            this.GpbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.StsBarraStatus.ResumeLayout(false);
            this.StsBarraStatus.PerformLayout();
            this.SslStatusConexao.ResumeLayout(false);
            this.SslStatusConexao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GpbLogin;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label LblSenha;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.CheckBox ChkVisualizarSenha;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.StatusStrip StsBarraStatus;
        private System.Windows.Forms.ToolStripStatusLabel StlData;
        private System.Windows.Forms.Timer TmrRelogio;
        private System.Windows.Forms.StatusStrip SslStatusConexao;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel TssStatusConexao;
    }
}


namespace DoeComPaixao.Telas
{
    partial class TelaCadFunc
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
            this.GpbCadastro = new System.Windows.Forms.GroupBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNivelAcesso = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.ChkAtivo = new System.Windows.Forms.CheckBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblNivelAcesso = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCodFunc = new System.Windows.Forms.Label();
            this.LblCodF = new System.Windows.Forms.Label();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.DgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.GpbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // GpbCadastro
            // 
            this.GpbCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.GpbCadastro.Controls.Add(this.TxtEmail);
            this.GpbCadastro.Controls.Add(this.TxtNivelAcesso);
            this.GpbCadastro.Controls.Add(this.TxtNome);
            this.GpbCadastro.Controls.Add(this.ChkAtivo);
            this.GpbCadastro.Controls.Add(this.LblEmail);
            this.GpbCadastro.Controls.Add(this.LblNivelAcesso);
            this.GpbCadastro.Controls.Add(this.LblNome);
            this.GpbCadastro.Controls.Add(this.LblCodFunc);
            this.GpbCadastro.Controls.Add(this.LblCodF);
            this.GpbCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GpbCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GpbCadastro.Location = new System.Drawing.Point(12, 12);
            this.GpbCadastro.Name = "GpbCadastro";
            this.GpbCadastro.Size = new System.Drawing.Size(723, 221);
            this.GpbCadastro.TabIndex = 0;
            this.GpbCadastro.TabStop = false;
            this.GpbCadastro.Text = "Cadastrar";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(114, 171);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(424, 35);
            this.TxtEmail.TabIndex = 10;
            // 
            // TxtNivelAcesso
            // 
            this.TxtNivelAcesso.Location = new System.Drawing.Point(387, 40);
            this.TxtNivelAcesso.Name = "TxtNivelAcesso";
            this.TxtNivelAcesso.Size = new System.Drawing.Size(34, 35);
            this.TxtNivelAcesso.TabIndex = 9;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(114, 110);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(424, 35);
            this.TxtNome.TabIndex = 8;
            // 
            // ChkAtivo
            // 
            this.ChkAtivo.AutoSize = true;
            this.ChkAtivo.Location = new System.Drawing.Point(449, 46);
            this.ChkAtivo.Name = "ChkAtivo";
            this.ChkAtivo.Size = new System.Drawing.Size(89, 33);
            this.ChkAtivo.TabIndex = 7;
            this.ChkAtivo.Text = "Ativo";
            this.ChkAtivo.UseVisualStyleBackColor = true;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(11, 177);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(102, 29);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "E-mail :";
            // 
            // LblNivelAcesso
            // 
            this.LblNivelAcesso.AutoSize = true;
            this.LblNivelAcesso.Location = new System.Drawing.Point(165, 46);
            this.LblNivelAcesso.Name = "LblNivelAcesso";
            this.LblNivelAcesso.Size = new System.Drawing.Size(216, 29);
            this.LblNivelAcesso.TabIndex = 5;
            this.LblNivelAcesso.Text = "Nivel de Acesso :";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(11, 116);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(97, 29);
            this.LblNome.TabIndex = 4;
            this.LblNome.Text = "Nome :";
            // 
            // LblCodFunc
            // 
            this.LblCodFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCodFunc.Location = new System.Drawing.Point(114, 46);
            this.LblCodFunc.Name = "LblCodFunc";
            this.LblCodFunc.Size = new System.Drawing.Size(45, 29);
            this.LblCodFunc.TabIndex = 1;
            // 
            // LblCodF
            // 
            this.LblCodF.AutoSize = true;
            this.LblCodF.Location = new System.Drawing.Point(11, 46);
            this.LblCodF.Name = "LblCodF";
            this.LblCodF.Size = new System.Drawing.Size(98, 29);
            this.LblCodF.TabIndex = 0;
            this.LblCodF.Text = "Código";
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.BtnCadastrar.Location = new System.Drawing.Point(12, 251);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(165, 46);
            this.BtnCadastrar.TabIndex = 1;
            this.BtnCadastrar.Text = "CADASTRAR";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.BtnAlterar.Location = new System.Drawing.Point(197, 251);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(165, 46);
            this.BtnAlterar.TabIndex = 2;
            this.BtnAlterar.Text = "ALTERAR";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.BtnExcluir.Location = new System.Drawing.Point(385, 251);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(165, 46);
            this.BtnExcluir.TabIndex = 3;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.BtnConsultar.Location = new System.Drawing.Point(570, 251);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(165, 46);
            this.BtnConsultar.TabIndex = 4;
            this.BtnConsultar.Text = "CONSULTAR";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            // 
            // DgvFuncionarios
            // 
            this.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionarios.Location = new System.Drawing.Point(12, 314);
            this.DgvFuncionarios.Name = "DgvFuncionarios";
            this.DgvFuncionarios.Size = new System.Drawing.Size(723, 347);
            this.DgvFuncionarios.TabIndex = 5;
            this.DgvFuncionarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // TelaCadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(747, 673);
            this.Controls.Add(this.DgvFuncionarios);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.GpbCadastro);
            this.Name = "TelaCadFunc";
            this.Text = "TelaCadFunc";
            this.GpbCadastro.ResumeLayout(false);
            this.GpbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbCadastro;
        private System.Windows.Forms.Label LblCodFunc;
        private System.Windows.Forms.Label LblCodF;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblNivelAcesso;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.CheckBox ChkAtivo;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNivelAcesso;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.DataGridView DgvFuncionarios;
    }
}
﻿namespace DoeComPaixao.Telas
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
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtNivelAcesso = new System.Windows.Forms.TextBox();
            this.ChkAtivo = new System.Windows.Forms.CheckBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblNivelAcesso = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCodFunc = new System.Windows.Forms.Label();
            this.LblCodF = new System.Windows.Forms.Label();
            this.DgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.GpbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // GpbCadastro
            // 
            this.GpbCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.GpbCadastro.Controls.Add(this.BtnExcluir);
            this.GpbCadastro.Controls.Add(this.BtnConsultar);
            this.GpbCadastro.Controls.Add(this.BtnAlterar);
            this.GpbCadastro.Controls.Add(this.BtnCadastrar);
            this.GpbCadastro.Controls.Add(this.TxtEmail);
            this.GpbCadastro.Controls.Add(this.TxtNome);
            this.GpbCadastro.Controls.Add(this.TxtNivelAcesso);
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
            this.GpbCadastro.Size = new System.Drawing.Size(980, 260);
            this.GpbCadastro.TabIndex = 0;
            this.GpbCadastro.TabStop = false;
            this.GpbCadastro.Text = "Cadastrar";
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.BtnExcluir.Location = new System.Drawing.Point(617, 194);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(186, 45);
            this.BtnExcluir.TabIndex = 14;
            this.BtnExcluir.Text = "EXCLUIR";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.BtnConsultar.Location = new System.Drawing.Point(421, 194);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(186, 45);
            this.BtnConsultar.TabIndex = 13;
            this.BtnConsultar.Text = "CONSULTAR";
            this.BtnConsultar.UseVisualStyleBackColor = false;
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.BtnAlterar.Location = new System.Drawing.Point(225, 194);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(186, 45);
            this.BtnAlterar.TabIndex = 12;
            this.BtnAlterar.Text = "ALTERAR";
            this.BtnAlterar.UseVisualStyleBackColor = false;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCadastrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(231)))), ((int)(((byte)(158)))));
            this.BtnCadastrar.Location = new System.Drawing.Point(28, 194);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(186, 45);
            this.BtnCadastrar.TabIndex = 11;
            this.BtnCadastrar.Text = "CADASTRAR";
            this.BtnCadastrar.UseVisualStyleBackColor = false;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(116, 133);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(410, 35);
            this.TxtEmail.TabIndex = 10;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(116, 76);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(410, 35);
            this.TxtNome.TabIndex = 9;
            // 
            // TxtNivelAcesso
            // 
            this.TxtNivelAcesso.Location = new System.Drawing.Point(392, 24);
            this.TxtNivelAcesso.Name = "TxtNivelAcesso";
            this.TxtNivelAcesso.Size = new System.Drawing.Size(39, 35);
            this.TxtNivelAcesso.TabIndex = 8;
            // 
            // ChkAtivo
            // 
            this.ChkAtivo.AutoSize = true;
            this.ChkAtivo.Checked = true;
            this.ChkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkAtivo.Location = new System.Drawing.Point(437, 27);
            this.ChkAtivo.Name = "ChkAtivo";
            this.ChkAtivo.Size = new System.Drawing.Size(89, 33);
            this.ChkAtivo.TabIndex = 7;
            this.ChkAtivo.Text = "Ativo";
            this.ChkAtivo.UseVisualStyleBackColor = true;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(7, 140);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(102, 29);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "E-mail :";
            // 
            // LblNivelAcesso
            // 
            this.LblNivelAcesso.AutoSize = true;
            this.LblNivelAcesso.Location = new System.Drawing.Point(159, 30);
            this.LblNivelAcesso.Name = "LblNivelAcesso";
            this.LblNivelAcesso.Size = new System.Drawing.Size(216, 29);
            this.LblNivelAcesso.TabIndex = 5;
            this.LblNivelAcesso.Text = "Nivel de Acesso :";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(7, 83);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(97, 29);
            this.LblNome.TabIndex = 4;
            this.LblNome.Text = "Nome :";
            // 
            // LblCodFunc
            // 
            this.LblCodFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCodFunc.Location = new System.Drawing.Point(116, 31);
            this.LblCodFunc.Name = "LblCodFunc";
            this.LblCodFunc.Size = new System.Drawing.Size(37, 29);
            this.LblCodFunc.TabIndex = 1;
            // 
            // LblCodF
            // 
            this.LblCodF.AutoSize = true;
            this.LblCodF.Location = new System.Drawing.Point(6, 31);
            this.LblCodF.Name = "LblCodF";
            this.LblCodF.Size = new System.Drawing.Size(112, 29);
            this.LblCodF.TabIndex = 0;
            this.LblCodF.Text = "Código :";
            // 
            // DgvFuncionarios
            // 
            this.DgvFuncionarios.AllowUserToAddRows = false;
            this.DgvFuncionarios.AllowUserToDeleteRows = false;
            this.DgvFuncionarios.AllowUserToResizeRows = false;
            this.DgvFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFuncionarios.Location = new System.Drawing.Point(12, 278);
            this.DgvFuncionarios.MultiSelect = false;
            this.DgvFuncionarios.Name = "DgvFuncionarios";
            this.DgvFuncionarios.ReadOnly = true;
            this.DgvFuncionarios.RowHeadersVisible = false;
            this.DgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFuncionarios.Size = new System.Drawing.Size(980, 282);
            this.DgvFuncionarios.TabIndex = 1;
            this.DgvFuncionarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvFuncionarios_CellFormatting);
            this.DgvFuncionarios.SelectionChanged += new System.EventHandler(this.DgvFuncionarios_SelectionChanged);
            // 
            // TelaCadFunc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1004, 572);
            this.Controls.Add(this.DgvFuncionarios);
            this.Controls.Add(this.GpbCadastro);
            this.Name = "TelaCadFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TelaCadFunc";
            this.Load += new System.EventHandler(this.TelaCadFunc_Load);
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
        private System.Windows.Forms.TextBox TxtNivelAcesso;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.DataGridView DgvFuncionarios;
    }
}
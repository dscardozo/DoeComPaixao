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
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblNivelAcesso = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCodFunc = new System.Windows.Forms.Label();
            this.LblCodF = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.GpbCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpbCadastro
            // 
            this.GpbCadastro.Controls.Add(this.checkBox1);
            this.GpbCadastro.Controls.Add(this.LblEmail);
            this.GpbCadastro.Controls.Add(this.LblNivelAcesso);
            this.GpbCadastro.Controls.Add(this.LblNome);
            this.GpbCadastro.Controls.Add(this.LblCodFunc);
            this.GpbCadastro.Controls.Add(this.LblCodF);
            this.GpbCadastro.Location = new System.Drawing.Point(12, 12);
            this.GpbCadastro.Name = "GpbCadastro";
            this.GpbCadastro.Size = new System.Drawing.Size(550, 193);
            this.GpbCadastro.TabIndex = 0;
            this.GpbCadastro.TabStop = false;
            this.GpbCadastro.Text = "Cadastrar";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(11, 126);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(41, 13);
            this.LblEmail.TabIndex = 6;
            this.LblEmail.Text = "E-mail :";
            // 
            // LblNivelAcesso
            // 
            this.LblNivelAcesso.AutoSize = true;
            this.LblNivelAcesso.Location = new System.Drawing.Point(11, 98);
            this.LblNivelAcesso.Name = "LblNivelAcesso";
            this.LblNivelAcesso.Size = new System.Drawing.Size(90, 13);
            this.LblNivelAcesso.TabIndex = 5;
            this.LblNivelAcesso.Text = "Nivel de Acesso :";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(11, 64);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(41, 13);
            this.LblNome.TabIndex = 4;
            this.LblNome.Text = "Nome :";
            // 
            // LblCodFunc
            // 
            this.LblCodFunc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCodFunc.Location = new System.Drawing.Point(61, 16);
            this.LblCodFunc.Name = "LblCodFunc";
            this.LblCodFunc.Size = new System.Drawing.Size(35, 13);
            this.LblCodFunc.TabIndex = 1;
            // 
            // LblCodF
            // 
            this.LblCodF.AutoSize = true;
            this.LblCodF.Location = new System.Drawing.Point(6, 16);
            this.LblCodF.Name = "LblCodF";
            this.LblCodF.Size = new System.Drawing.Size(40, 13);
            this.LblCodF.TabIndex = 0;
            this.LblCodF.Text = "Código";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(122, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // TelaCadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GpbCadastro);
            this.Name = "TelaCadFunc";
            this.Text = "TelaCadFunc";
            this.GpbCadastro.ResumeLayout(false);
            this.GpbCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbCadastro;
        private System.Windows.Forms.Label LblCodFunc;
        private System.Windows.Forms.Label LblCodF;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblNivelAcesso;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
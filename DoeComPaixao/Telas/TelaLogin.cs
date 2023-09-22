using DoeComPaixao.Classes;
using DoeComPaixao.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoeComPaixao
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
            
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            StlData.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToLongTimeString();
            TmrRelogio.Interval = 1000;
            TmrRelogio.Enabled = true;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TxtEmail.Clear();
            TxtSenha.Clear();
        }

        private void CkbVisualizarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkVisualizarSenha.Checked)

                TxtSenha.UseSystemPasswordChar = false;

            else

                TxtSenha.UseSystemPasswordChar = true;
        }

        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void TxtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void ChkVisualizarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void TmrRelogio_Tick(object sender, EventArgs e)
        {
            StlData.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToLongTimeString();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            TssStatusConexao.Text = "Conectando, aguarde . . . ";

            try
            {
                
                Cliente logado = Cliente.RealizarLogin(TxtEmail.Text, TxtSenha.Text);
                
                TssStatusConexao.Text = "Conectado!";

                TelaPrincipal tlPrincipal = new TelaPrincipal(logado);               
                tlPrincipal.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                toolStripStatusLabel1.Text = "Falhou";
                MessageBox.Show(ex.Message
                              , "Doe ComPaixão"
                              , MessageBoxButtons.OK
                              , MessageBoxIcon.Error);
            }
        }
    }
}

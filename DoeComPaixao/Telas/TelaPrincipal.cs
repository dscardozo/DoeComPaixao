using DoeComPaixao.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoeComPaixao.Telas
{
    public partial class TelaPrincipal : Form
    {
        private Funcionario _funcLogado;

        public TelaPrincipal(Funcionario logado)
        {
            
            InitializeComponent();
            _funcLogado = logado;
            
            
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            TsmTrocarSair.Alignment = ToolStripItemAlignment.Right;
            TslLogado.Text = _funcLogado.Nome;
            TslNivelAcesso.Text = _funcLogado.NivelAcesso.ToString();
            if (_funcLogado.NivelAcesso == 1)
            {

                TslDescNivel.Text = "Adminstrador";

            }
            else
            {
                TslDescNivel.Text = "Funcionário";

            }
            TssDataHora.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToLongTimeString();
            TmrRelogio.Interval = 1000;
            TmrRelogio.Enabled = true;
        }

        private void TmrRelogio_Tick(object sender, EventArgs e)
        {
            TssDataHora.Text = DateTime.Now.ToLongDateString() + "   " + DateTime.Now.ToLongTimeString();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadFunc tlCadFunc = new TelaCadFunc(_funcLogado);
            tlCadFunc.MdiParent = this;

            tlCadFunc.Show();
        }

        private void anúncioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Você realmente deseja Sair {_funcLogado.Nome}?"
                              , "Sair"
                              , MessageBoxButtons.YesNo
                              , MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Close();
                }
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void trocarDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Você realmente Trocar de usuário {_funcLogado.Nome}?"
                              , "Trocar"
                              , MessageBoxButtons.YesNo
                              , MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    TelaLogin tlLogin = new TelaLogin();
                    tlLogin.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}

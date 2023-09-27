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
    }
}

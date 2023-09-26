using DoeComPaixao.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoeComPaixao.Telas
{
    public partial class TelaCadFunc : Form
    {
        private List<Funcionario> _funcionarios;
        private Funcionario _funcionarioSelecionado;
        private Funcionario _logado;
        public TelaCadFunc(Funcionario logado)
        {
            InitializeComponent();
            _logado = (Funcionario)logado;
        }

        private void CarregaDgvFuncionarios(List<Funcionario> funcionarios = null)
        {
            DgvFuncionarios.Rows.Clear();

            foreach (Funcionario funcionario in funcionarios == null ? _funcionarios : funcionarios)
            {
                DgvFuncionarios.Rows.Add(funcionario.CodFunc, funcionario.Nome, funcionario.Email, funcionario.Senha, funcionario.NivelAcesso, funcionario.Ativo);
                if (!funcionario.Ativo)
                {
                    DgvFuncionarios.Rows[DgvFuncionarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
                    if (_logado.NivelAcesso != 1)
                    {
                        DgvFuncionarios.Rows[DgvFuncionarios.Rows.Count - 1].Visible = false;
                        DgvFuncionarios.Columns[DgvFuncionarios.Columns.Count - 1].Visible = false;
                    }
                }
            }
        }
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
           
        }        

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (_funcionarioSelecionado.Ativo != true)
            {
                try
                {

                    BtnExcluir.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else if (_logado.NivelAcesso == 1)
            {
                try
                {
                    DialogResult dr = MessageBox.Show($"Você realmente deseja desativar o Professor(a) {_funcionarioSelecionado.Nome}?"
                                  , "Remover Professor"
                                  , MessageBoxButtons.YesNo
                                  , MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        _funcionarioSelecionado.Ativo = false;
                        _funcionarioSelecionado.Excluir();
                        CarregaDgvFuncionarios();
                        
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DgvFuncionarios.Columns["Ativo"].Index)
            {
                DataGridViewRow row = DgvFuncionarios.Rows[e.RowIndex];
                bool ativo = Convert.ToBoolean(row.Cells["Ativo"].Value);

                if (!ativo)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }
    }
}

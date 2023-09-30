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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoeComPaixao.Telas
{
    public partial class TelaCadFunc : Form
    {
        private List<Funcionario> _funcionarios;
        private Funcionario _logado;
        private Funcionario _funcionarioSelecionado;
        public TelaCadFunc(Funcionario logado)
        {
            InitializeComponent();
            _logado = logado;

            try
            {
                _funcionarios = Funcionario.BuscarFuncionarios();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }
        private void ConfiguraDgvFuncionarios()
        {
            DgvFuncionarios.Columns.Add("CodFunc", "Código");
            DgvFuncionarios.Columns.Add("Nome", "Nome");           
            DgvFuncionarios.Columns.Add("Email", "E-mail");
            DgvFuncionarios.Columns.Add("NivelAcesso", "Tipo Acesso");
            DgvFuncionarios.Columns.Add("Ativo", "Ativo");

            DgvFuncionarios.Columns["CodFunc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvFuncionarios.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvFuncionarios.Columns["NivelAcesso"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvFuncionarios.Columns["Ativo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvFuncionarios.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DgvFuncionarios.Columns["CodFunc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvFuncionarios.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvFuncionarios.Columns["NivelAcesso"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvFuncionarios.Columns["Ativo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvFuncionarios.Columns["Email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            DgvFuncionarios.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            DgvFuncionarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        private void CarregaDgvFuncionarios(List<Funcionario> funcionarios = null)
        {
            DgvFuncionarios.Rows.Clear();

            foreach (Funcionario funcionario in funcionarios == null ? _funcionarios : funcionarios)
            {
                DgvFuncionarios.Rows.Add(funcionario.CodFunc, funcionario.Nome, funcionario.Email, funcionario.NivelAcesso, funcionario.Ativo ? "Ativo" : "Inativo" );
                if (!funcionario.Ativo)
                {
                    DgvFuncionarios.Rows[DgvFuncionarios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }            
        }       

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (_logado.NivelAcesso != NivelAcesso.Administrador)
            {
                BtnCadastrar.Enabled = false;
                MessageBox.Show("Seu Nivel de acesso não permite cadastrar funcionários.",
                                "Erro de permissão",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; 
            }


            try
            {
                if (TxtEmail.Text != "" && TxtNome.Text != "")
                {
                    Funcionario funcionario = new Funcionario(0
                                            , TxtNome.Text                                                                                        
                                            , "123"
                                            , 1
                                            , true
                                            , TxtEmail.Text);

                    funcionario.Cadastrar(_funcionarios);
                    CarregaDgvFuncionarios();
                    LimpaCampos();
                }
                else
                {
                    MessageBox.Show("Os campos Nome e E-mail precisam ser preenchidos.",
                                    "Campo Obrigatório",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }
        public void LimpaCampos()
        {
            LblCodFunc.Text = "";
            TxtNome.Clear();
            TxtEmail.Clear();           
            LblNivelAcesso.Text = "";
            ChkAtivo.Checked = true;
            ChkAtivo.Enabled = false;

            DgvFuncionarios.ClearSelection();
            BtnCadastrar.Enabled = true;
            BtnAlterar.Enabled = false;
            BtnReativar.Enabled = false;
            BtnReativar.FlatAppearance.BorderColor = Color.Salmon;
            CbbBuscar.SelectedIndex = 0;
        }
        private void DgvFuncionarios_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvFuncionarios.Rows.Count < 1 || DgvFuncionarios.SelectedRows.Count < 1)
            {
                return;
            }
            try
            {
                _funcionarioSelecionado = _funcionarios.Find(f => f.CodFunc == (int)DgvFuncionarios.SelectedRows[0].Cells[0].Value);
                LblCodFunc.Text = _funcionarioSelecionado.CodFunc.ToString();
                LblNivelAcesso.Text = _funcionarioSelecionado.NivelAcesso.ToString();
                           
                TxtNome.Text = _funcionarioSelecionado.Nome;
                TxtEmail.Text = _funcionarioSelecionado.Email;
               
                ChkAtivo.Checked = _funcionarioSelecionado.Ativo;


                BtnCadastrar.Enabled = false;
                BtnAlterar.Enabled = true;

                if (_funcionarioSelecionado.Ativo == false)
                {
                    BtnReativar.Enabled = true;
                    BtnReativar.FlatAppearance.BorderColor = Color.Green;
                }
                else

                {
                    BtnReativar.Enabled = false;
                    BtnReativar.FlatAppearance.BorderColor = Color.Salmon;
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
        private void TelaCadFunc_Load(object sender, EventArgs e)
        {
            try
            {
                ConfiguraDgvFuncionarios();
                CarregaDgvFuncionarios();

                CbbTipoNivelAcesso.DataSource = Enum.GetValues(typeof(NivelAcesso));

                LimpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            List<Funcionario> listaFuncFiltrada = Funcionario.Buscar(_funcionarios, CbbBuscar.SelectedIndex, CbbBuscar.SelectedIndex == 3 ? CbbTipoNivelAcesso.SelectedValue.ToString() : TxtBuscar.Text);
            CarregaDgvFuncionarios(listaFuncFiltrada);
        }
        private void BtnLimparBusca_Click(object sender, EventArgs e)
        {
            TxtBuscar.Clear();
        }
        private void BtnReativar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show($"Você realmente deseja reativar o Funcionário(a) {_funcionarioSelecionado.Nome}?"
                              , "Reativar Funcionário"
                              , MessageBoxButtons.YesNo
                              , MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    _funcionarioSelecionado.Ativo = true;
                    _funcionarioSelecionado.Reativar();

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
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (_funcionarioSelecionado.Ativo != true)
            {
                try
                {

                    BtnReativar.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else if (_logado.NivelAcesso == NivelAcesso.Administrador)
            {
                try
                {
                    DialogResult dr = MessageBox.Show($"Você realmente deseja desativar o Funcionario(a) {_funcionarioSelecionado.Nome}?"
                                  , "Remover Funcionario"
                                  , MessageBoxButtons.YesNo
                                  , MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        _funcionarioSelecionado.Ativo = false;
                        _funcionarioSelecionado.Excluir();
                        CarregaDgvFuncionarios();
                        LimpaCampos();
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

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnBuscar.PerformClick();
            }
        }

        private void TelaCadFunc_Shown(object sender, EventArgs e)
        {
            TxtBuscar.Focus();
        }
       
        private void CbbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbbBuscar.SelectedIndex == 3)
            {
                TxtBuscar.Visible = false;
                CbbTipoNivelAcesso.Visible = true;
            }
            else
            {
                TxtBuscar.Visible = true;
                CbbTipoNivelAcesso.Visible = false;
            }
        }
    }
}


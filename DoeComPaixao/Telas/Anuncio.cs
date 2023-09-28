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
    public partial class Anuncio : Form
    {
        private List<Anuncio> _anuncios;
        private Anuncio _logado;
        private Anuncio _anuncioSelecionado;
        public Anuncio(Anuncio logado)
        {
            InitializeComponent();
            _logado = logado;
            try
            {
                _anuncios = Anuncio.BuscarAnuncios().ConvertAll(a => (Anuncio)a);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
        }
        private void ConfiguraDgvAnuncio()
        {
            DgvAnuncios.Columns.Add("CodAnuncio", "Código do Anúncio");
            DgvAnuncios.Columns.Add("Titulo", "Título");
            DgvAnuncios.Columns.Add("Descricao", "Descrição");
            DgvAnuncios.Columns.Add("Status", "status");
            DgvAnuncios.Columns.Add("DthCriacao", "Data de Criação");
            DgvAnuncios.Columns.Add("DthFinalizado", "Data De Finalização");
            DgvAnuncios.Columns.Add("ValorArrecadado", "valor Arrecadado");



            DgvAnuncios.Columns["CodAnuncio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvAnuncios.Columns["Titulo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvAnuncios.Columns["Descricao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvAnuncios.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvAnuncios.Columns["DthCriacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvAnuncios.Columns["DthFinalizado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DgvAnuncios.Columns["ValorArrecadado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            Dgvanuncios.Columns["CodAnuncio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvAnuncios.Columns["Titulo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvAnuncios.Columns["descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvAnuncios.Columns["Status"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            DgvAnuncios.Columns["DthCriacao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvAnuncios.Columns["DthFinalizado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DgvAnuncios.Columns["ValorArrecadado"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;



            DgvAnuncios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DgvAnuncios.ColumnHeadersHeight = 35;
            DgvAnuncios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
        private void CarregaDgvAnuncio(List<Anuncio> anuncios = null)
        {
            DgvAnuncios.Rows.Clear();

            foreach (Anuncio anuncio in anuncios == null ? _anuncios : anuncios)
            {
                DgvAnuncios.Rows.Add(anuncio.CodAnuncio, anuncio.Titulo, anuncio., anuncio., anuncio.);
                if (!anuncio.Ativo)
                {
                    DgvAnuncios.Rows[DgvAnuncios.Rows.Count - 1].DefaultCellStyle.BackColor = Color.LightCoral;
                    if (_logado.NivelAcesso != 1)
                    {
                        DgvFuncionarios.Rows[DgvFuncionarios.Rows.Count - 1].Visible = false;
                        DgvFuncionarios.Columns[DgvFuncionarios.Columns.Count - 1].Visible = false;
                    }
                }
            }
        }
        private void DgvFuncionarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (_logado.NivelAcesso != 1)
            {
                BtnCadastrar.Enabled = false;
                MessageBox.Show("Seu Nivel de acesso não permite cadastrar alunos",
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
            LblNivelAcess.Text = "";
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
            List<Funcionario> listaFuncFiltrada = Funcionario.Buscar(_funcionarios, CbbBuscar.SelectedIndex, TxtBuscar.Text);
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
            else if (_logado.NivelAcesso == 1)
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

    }
}

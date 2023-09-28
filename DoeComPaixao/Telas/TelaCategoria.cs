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
    public partial class TelaCategoria : Form
    {
        private List<Categorias> _categorias;
        private Funcionario _logado;

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (_logado.NivelAcesso != 1)
            {
                MessageBox.Show("Você não possui permissão para cadastrar.",
                                "Erro de Permissão",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; //Mata o método (encerra)
            }

            try
            {
                Categorias categorias = new Categorias(TxtIdCategorias,
                                        TxtNomeCategorias);

                categorias.Adicionar(_categorias);
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

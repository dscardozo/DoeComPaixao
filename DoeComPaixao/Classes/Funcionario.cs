using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoeComPaixao.Classes
{
    public class Funcionario : Cliente
    {
        #region Propriedades
        public int CodFunc { get; set; }
        public int NivelAcesso { get; set; }
        public bool Ativo { get; set; }

        #endregion

        #region Construtores

        public Funcionario()
        {
            
        }

        public Funcionario(int codCliente, string nome, string cpf, string email, string senha, int nivelAcesso, int tipo, bool flagCNH, int codEndereco, decimal rendaFamiliar, int carteira, bool ativo) : base(codCliente,nome,cpf,email,senha,tipo,flagCNH,codEndereco,rendaFamiliar,carteira)
        {
            CodFunc = codCliente;
            NivelAcesso = nivelAcesso;
            Ativo = ativo;
            
        }
        #endregion

        #region Métodos
        public void Cadastrar(List<Funcionario> funcionarios)
        {                                                                                                                                      
            string query = string.Format($"INSERT INTO Funcionario VALUES ('{Nome}','{Crypto.Sha256(Senha)}','{NivelAcesso}','{Ativo}','{Email}'); SELECT SCOPE_IDENTITY()");

            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                CodFunc = Convert.ToInt32(cn.comando.ExecuteScalar());
                funcionarios.Add(this);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.FecharConexao();
            }
        }
        public void Alterar()
        {
            string query = string.Format($"UPDATE Funcionario SET Nome = '{Nome}', NivelAcesso = '{NivelAcesso}', Ativo = '{Ativo}', Email = '{Email}' WHERE Id = '{CodFunc}'");
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
            finally
            {
                cn.FecharConexao();
            }

        }
        public void Excluir()
        {
            string query = string.Format($"UPDATE Funcionario SET Ativo = '{0}' WHERE Id = '{CodFunc}'");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
            }
            finally
            {
                cn.FecharConexao();
            }

        }
        public static List<Funcionario> Buscar(List<Funcionario> funcionarios, int indexCbbBuscar, string texto)
        {
            switch (indexCbbBuscar)
            {
                case 0:
                    //Busca por nome
                    return funcionarios.Where(f => f.Nome.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();
                //break; quando não for returno o Break é obrigatório
                case 1:
                    // Busca por E-mail
                    return funcionarios.Where(f => f.Email.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();
                //break; quando não for returno o Break é obrigatório
                case 2:
                    // Buscar por matricula (id)
                    return funcionarios.Where(f => f.CodFunc == Convert.ToInt32(texto)).ToList();
                //break; quando não for returno o Break é obrigatório

                default:
                    // Retorna sem filtro
                    return funcionarios;
                    //break; quando não for returno o Break é obrigatório
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoeComPaixao.Classes
{
    public class Funcionario 
    {
        #region Propriedades
        public int CodFunc { get; set; }
        public string Nome { get; set; }       
        public string Senha { get; set; }
        public int NivelAcesso { get; set; }
        public bool Ativo { get; set; }
        public string Email { get; set; }

        #endregion

        #region Construtores

        public Funcionario()
        {
            
        }

        public Funcionario(int codFunc, string nome, string senha, int nivelAcesso, bool ativo, string email)
        {
            CodFunc = codFunc;
            Nome = nome;            
            Senha = senha;
            NivelAcesso = nivelAcesso;
            Ativo = ativo;
            Email = email;
        }


        #endregion

        #region Métodos

        public static Funcionario RealizarLogin(string email, string senha)
        {
            string query = string.Format($"SELECT * FROM Funcionario WHERE Email = '{email}'");
            Conexao cn = new Conexao(query);
            Funcionario funcionario = new Funcionario();

            try
            {
                cn.AbrirConexao();
                cn.dr = cn.comando.ExecuteReader();

                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        funcionario.CodFunc = Convert.ToInt32(cn.dr[0]);
                        funcionario.Nome = cn.dr[1].ToString();                        
                        funcionario.Senha = cn.dr[2].ToString();
                        funcionario.NivelAcesso = Convert.ToInt32(cn.dr[3]);
                        funcionario.Ativo = Convert.ToBoolean(cn.dr[4]);
                        funcionario.Email = cn.dr[5].ToString();
                    }

                    if (funcionario.Senha == Crypto.Sha256(senha))
                    {
                        if (funcionario.Ativo)
                        {
                            return funcionario;
                        }
                        else
                        {
                            throw new Exception("Usuário bloqueado");
                        }
                    }
                    else
                    {
                        throw new Exception("Senha incorreta!");
                    }

                }
                else
                {
                    throw new Exception("E-mail inexistente!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Cadastrar(List<Funcionario> funcionarios)
        {
            string query = string.Format($"INSERT INTO Funcionario VALUES ('{Nome}','{Crypto.Sha256(Senha)}','1','1','{Email}'); SELECT SCOPE_IDENTITY()");

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
            string query = string.Format($"UPDATE Funcionario SET Ativo = '{0}' WHERE CodFunc = '{CodFunc}'");
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
                    return funcionarios.Where(f => f.Nome.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();
                case 1:
                    return funcionarios.Where(f => f.Email.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();
                case 2:
                    return funcionarios.Where(f => f.CodFunc == Convert.ToInt32(texto)).ToList();
                case 3:
                    return funcionarios.Where(f => f.NivelAcesso == Convert.ToInt32(texto)).ToList();
                default:
                    return funcionarios;
            }
        }
        public static List<Funcionario> BuscarFuncionarios()
        {
            string query = string.Format("SELECT * FROM Funcionario");
            Conexao cn = new Conexao(query);
            List<Funcionario> funcionarios = new List<Funcionario>();
            try
            {
                cn.AbrirConexao();
                cn.dr = cn.comando.ExecuteReader();
                while (cn.dr.Read())
                {
                    funcionarios.Add(new Funcionario()
                    {
                        CodFunc = Convert.ToInt32(cn.dr[0]),
                        Nome = cn.dr[1].ToString(),                        
                        Senha = cn.dr[2].ToString(),
                        NivelAcesso = Convert.ToInt32(cn.dr[3]),
                        Ativo = Convert.ToBoolean(cn.dr[4]),
                        Email = cn.dr[5].ToString()
                    });
                }
                return funcionarios;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Reativar()
        {
            string query = string.Format($"UPDATE Funcionario SET Ativo = '{1}' WHERE CodFunc = '{CodFunc}'");
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

        #endregion
    }
}

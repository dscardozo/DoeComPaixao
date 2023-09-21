using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeComPaixao.Classes
{
    public class Cliente
    {
        #region Propriedades
        public int CodCliente { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Tipo { get; set; }
        public bool FlagCNH { get; set; }
        public int CodEndereco { get; set; }
        public decimal RendaFamiliar { get; set; }
        public int Carteira { get; set; }
        

        #endregion

        #region Construtor
        public Cliente()
        {
                
        }

        public Cliente(int codCliente, string nome, string cpf, string email, string senha, int tipo, bool flagCnh, int codEndereco, decimal rendaFamiliar, int carteira)
        {
            CodCliente = codCliente;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;
            Tipo = tipo;
            FlagCNH = flagCnh;
            CodEndereco = codEndereco;
            RendaFamiliar = rendaFamiliar;
            Carteira = carteira;
            
        }
        #endregion

        #region Métodos

        public static Cliente RealizarLogin(string email, string senha)
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
                        funcionario.CodCliente = Convert.ToInt32(cn.dr[0]);
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
            #endregion
        }
    }
}

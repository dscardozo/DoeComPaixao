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
        public bool Ativo { get; set; }


        #endregion

        #region Construtor
        public Cliente()
        {
                
        }

        public Cliente(int codCliente, string nome, string cpf, string email, string senha, int tipo, bool flagCnh, int codEndereco, decimal rendaFamiliar, int carteira, bool ativo)
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
            Ativo = ativo;
        }
        #endregion

        #region Métodos

        public static Cliente RealizarLogin(string email, string senha)
        {
            string query = string.Format($"SELECT * FROM Cliente WHERE Email = '{email}'");
            Conexao cn = new Conexao(query);
            Cliente cliente = new Cliente();

            try
            {
                cn.AbrirConexao();
                cn.dr = cn.comando.ExecuteReader();

                if (cn.dr.HasRows)
                {
                    while (cn.dr.Read())
                    {
                        cliente.CodCliente = Convert.ToInt32(cn.dr[0]);
                        cliente.Nome = cn.dr[1].ToString();
                        cliente.Cpf = cn.dr[2].ToString();
                        cliente.Email = cn.dr[3].ToString();
                        cliente.Senha = cn.dr[4].ToString();
                        cliente.Tipo = Convert.ToInt32(cn.dr[5]);
                        cliente.FlagCNH = Convert.ToBoolean(cn.dr[6]);
                        cliente.CodEndereco = Convert.ToInt32(cn.dr[7]);
                        cliente.RendaFamiliar = Convert.ToDecimal(cn.dr[8]);
                        cliente.Carteira = Convert.ToInt32(cn.dr[9]);

                    }

                    if (cliente.Senha == Crypto.Sha256(senha))
                    {
                        if (cliente.Ativo)
                        {
                            return cliente;
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

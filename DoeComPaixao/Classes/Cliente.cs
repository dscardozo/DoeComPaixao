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

        
    }
}

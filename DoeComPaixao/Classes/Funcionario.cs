using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

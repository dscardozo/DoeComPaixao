using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeComPaixao.Classes
{
    internal class Conexao
    {
        
        #region Variáveis
                                    
        private static string _strConexao = @"Data Source=VPR0687139W10-1;Initial Catalog=DoeComPaixao;Integrated Security=True";
        public SqlConnection conexao = new SqlConnection(_strConexao);
        public SqlCommand comando; 
        public SqlDataAdapter da; 
        public SqlDataReader dr; 
        public DataSet ds; 
        #endregion

        #region Construtores

        public Conexao(string query)
        {
            comando = new SqlCommand(query, conexao); 
            da = new SqlDataAdapter(query, conexao); 
            ds = new DataSet(); 
        }

        #endregion

        #region Métodos

        
        public void AbrirConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
            conexao.Open();
        }

        public void FecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoeComPaixao.Classes
{
    internal class Anuncio
    {
        #region Propriedades
        public int CodAnun { get; set; }
        public int CodCli { get; set; } 
        public string NomeCli { get; set; }
        public string TituloAnun { get; set; }
        public string Descricao { get; set; }
        public DateTime DtCriacao { get; set; }
        #endregion

        #region Construtores
        public Anuncio()
        {

        }
        public Anuncio(int codAnun, int codCli, string nomeCli, string tituloAnun, string descricao, DateTime dtCriacao)
        {
            CodAnun = codAnun;
            CodCli = codCli;
            NomeCli = nomeCli;
            TituloAnun = tituloAnun;
            Descricao = descricao;
            DtCriacao = dtCriacao;
        }
        #endregion

        #region Métodos
        public void AceitarAnuncio () 
        {
            string query = string.Format($"SELECT A.CodAnuncio = '{CodAnun}', A.ClienteAnunciante = '{CodCli}', C.Nome = '{NomeCli}', A.Titulo = '{TituloAnun}', A.Descricao = '{Descricao}', A. = '{DtCriacao}' FROM Anuncio AS A INNER JOIN  Cliente AS C ON A.ClienteAnunciante = C.CodCliente");
            Conexao cn = new Conexao(query);
            try
            {
                cn.AbrirConexao();
                cn.dr = cn.comando.ExecuteReader();
                while (cn.dr.Read())
                {
                    anuncios.Add(new Anuncio()
                    {
                        CodAnun = Convert.ToInt32(cn.dr[0]),
                        CodCli = Convert.ToInt32(cn.dr[1]),
                        NomeCli = cn.dr[2].ToString(),
                        TituloAnun = cn.dr[3].ToString(),
                        Descricao= cn.dr[4].ToString(), 
                        DtCriacao = Convert.ToDateTime(cn.dr[5]),   
                    });
                }
                return anuncios;
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
        public void RejeitarAnuncio() 
        { 
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DoeComPaixao.Classes
{
    internal class Categorias
    {
        #region Propiedades
        public int CodCategoria { get; set; }
        public string Nome { get; set; }
        public int CategoriaSuperior { get; set; } //não sei como vai funcionar essa Ctegoria Superior ent não vou mexer mt nela ass:Matheuzinho :)
        #endregion

        #region Construtores

        public Categorias()
        {
                
        }

        public Categorias(int codCategoria, string nome, int categoriaSuperior)
        {
            CodCategoria = codCategoria;
            Nome = nome;
            CategoriaSuperior = categoriaSuperior;
        }

        #endregion

        #region Métodos
        public void Excluir()//Excluir Categorias
        {
            string query = string.Format($"UPDATE Categoria SET Ativo = '{0}' WHERE Id = '{CodCategoria}'");
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

        public void Incluir (List<Categorias> categorias)//Incluir/Criar Categorias
        {
            string query = string.Format($"INSERT INTO Categoria VALUES('{CodCategoria}', '{CategoriaSuperior}', '{Nome}')");
            query += "; SELECT SCOPE_IDENTITY()";
            Conexao cn = new Conexao(query);

            try
            {
                cn.AbrirConexao();
                CodCategoria = Convert.ToInt32(cn.comando.ExecuteScalar());
                categorias.Add(this);
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

        public static List<Categorias> Buscar(List<Categorias> categorias, int indexCbbBuscar, string texto) //Buscar por Categorias
        {
            switch (indexCbbBuscar)
            {
                case 0:
                    //Busca por nome
                    return categorias.Where(f => f.Nome.ToUpper().Normalize(NormalizationForm.FormD).Contains(texto.ToUpper().Normalize(NormalizationForm.FormD))).ToList();
                //break; quando não for returno o Break é obrigatório
               
                case 2:
                    // Buscar por CodCategoria (id)
                    return categorias.Where(f => f.CodCategoria == Convert.ToInt32(texto)).ToList();
                //break; quando não for returno o Break é obrigatório

                case 3:
                    // Buscar por CategoriaSuperior
                    return categorias.Where(f => f.CategoriaSuperior == Convert.ToInt32(texto)).ToList();
                //break; quando não for returno o Break é obrigatório

                default:
                    // Retorna sem filtro
                    return categorias;
                    //break; quando não for returno o Break é obrigatório
            }
        }

        public void Alterar() //Alterar Categorias
        {
            string query = string.Format($"UPDATE Categoria SET CategoriaSuperior = '{CategoriaSuperior}, 'Nome {Nome}' WHERE Id = '{CodCategoria}'");
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

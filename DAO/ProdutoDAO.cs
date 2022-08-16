using GTIMVC.MODEL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProdutoDao
    {
        #region Listar
        public List<Produto> Listar()
        {
            SqlConnection con = null;
            List<Produto> lstProduto = null;

            try
            {
                string strConexao = ConfigurationManager.ConnectionStrings["conAlex"].ConnectionString;


                con = new SqlConnection(strConexao);
                con.Open();

                SqlCommand cmd = new SqlCommand("USP_L_PRODUTO", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader radProduto = cmd.ExecuteReader();
                lstProduto = new List<Produto>();


                while (radProduto.Read())
                {
                    Produto produto = new Produto
                    {
                        Id = Convert.ToInt32(radProduto["Id"]),
                        Categoria  = new Categoria()
                        {
                            Descricao = (string)(radProduto["Categoria"]),
                        },

                        Nome = (string)radProduto["Nome"],
                        Marca = (string)radProduto["Marca"],
                        Fornecedor = (string)(radProduto["Fornecedor"]),
                        Peso = Convert.ToDouble((radProduto["Peso"])),

                    };


                    lstProduto.Add(produto);
                }

            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return lstProduto;
        }
        #endregion

        #region Inserir
        //------------------------------------------------------------------------------------------
        public int Inserir(Produto produto)
        {
            int idProduto = 0;
            SqlConnection con = null;

            try
            {
                string strConexao = ConfigurationManager.ConnectionStrings["conAlex"].ConnectionString;
                con = new SqlConnection(strConexao);
                con.Open();


                SqlCommand cmd = new SqlCommand("USP_I_PRODUTO", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nome", produto.Categoria);
                cmd.Parameters.AddWithValue("@Cpf", produto.Nome);
                cmd.Parameters.AddWithValue("@Rg", produto.Marca);
                cmd.Parameters.AddWithValue("@UfExpedicao", produto.Fornecedor);
                cmd.Parameters.AddWithValue("@Sexo", produto.Peso);

                idProduto = Convert.ToInt32(cmd.ExecuteScalar());
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
            return idProduto;
        }
        #endregion
    }
}

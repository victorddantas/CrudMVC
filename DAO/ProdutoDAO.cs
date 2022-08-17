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

                cmd.Parameters.AddWithValue("@CategoriaId", produto.CategoriaId);
                cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                cmd.Parameters.AddWithValue("@Marca", produto.Marca);
                cmd.Parameters.AddWithValue("@Fornecedor", produto.Fornecedor);
                cmd.Parameters.AddWithValue("@Peso", produto.Peso);

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

        #region Atualizar
        public void Atualizar(Produto produto)
        {
            SqlConnection con = null;

            try
            {
                string strConexao = ConfigurationManager.ConnectionStrings["conAlex"].ConnectionString;
                con = new SqlConnection(strConexao);
                con.Open();

                SqlCommand cmd = new SqlCommand("USP_U_PRODUTO", con);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", produto.Id);
                cmd.Parameters.AddWithValue("@CategoriaId", produto.CategoriaId);
                cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                cmd.Parameters.AddWithValue("@Marca", produto.Marca);
                cmd.Parameters.AddWithValue("@Fornecedor", produto.Fornecedor);
                cmd.Parameters.AddWithValue("@Peso", produto.Peso);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
        #endregion

        #region Obter
        public Produto Obter(int id)
        {
            SqlConnection con = null;
            Produto produto = null;

            try
            {
                string strConexao = ConfigurationManager.ConnectionStrings["conAlex"].ConnectionString;
                con = new SqlConnection(strConexao);
                con.Open();

                SqlCommand cmd = new SqlCommand("USP_O_PRODUTO", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("id", id);

                SqlDataReader radProdutos = cmd.ExecuteReader();


                if (radProdutos.Read())
                {
                    produto = new Produto();

                    produto.CategoriaId = Convert.ToInt32(radProdutos["CategoriaId"]);
                    produto.Nome = (string)radProdutos["Nome"];
                    produto.Marca = (string)radProdutos["Marca"];
                    produto.Fornecedor = (string)(radProdutos["Fornecedor"]);
                    produto.Peso = (double)(radProdutos["Peso"]);

                }

            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return produto;
        }
        #endregion

        #region Excluir
        public void Excluir(int id)
        {
            SqlConnection con = null;

            try
            {
                string strConexao = ConfigurationManager.ConnectionStrings["conAlex"].ConnectionString;
                con = new SqlConnection(strConexao);
                con.Open();

                SqlCommand cmd = new SqlCommand("USP_D_PRODUTO", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", id);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                if (con != null)
                    con.Close();
            }
        }
        #endregion
    }
}

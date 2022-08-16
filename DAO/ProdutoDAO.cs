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
    public class ProdutoDAO
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
                        IDProduto = Convert.ToInt32(radProduto["IDProduto"]),
                        IDProdutoCategoria = Convert.ToInt32(radProduto["IDProdutoCategoria"]),
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
    }
}

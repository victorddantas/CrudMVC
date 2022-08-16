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
    public class CategoriaDao
    {
        #region Listar
        public List<Categoria> Listar()
        {
            SqlConnection con = null;
            List<Categoria> lstCategoria = null;

            try
            {
                string strConexao = ConfigurationManager.ConnectionStrings["conAlex"].ConnectionString;


                con = new SqlConnection(strConexao);
                con.Open();

                SqlCommand cmd = new SqlCommand("USP_L_CATEGORIA", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader radCategoria = cmd.ExecuteReader();
                lstCategoria = new List<Categoria>();


                while (radCategoria.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        Id = Convert.ToInt32((radCategoria["Id"])),
                        Descricao = (string)(radCategoria["Descricao"]),
                       
                    };


                    lstCategoria.Add(categoria);
                }

            }
            finally
            {
                if (con != null)
                    con.Close();
            }

            return lstCategoria;
        }
        #endregion
     
    }
}


using DAO;
using GTIMVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTIMVC.BL
{
    public class ProdutoBL
    {
        #region Listar
        public List<Produto> Listar()
        {
            return new ProdutoDao().Listar();
        }
        #endregion

        #region Inserir
        public int Inserir(Produto produto)
        {
            ProdutoDao dao = new ProdutoDao();

            return dao.Inserir(produto);


        }
        #endregion
    }
}

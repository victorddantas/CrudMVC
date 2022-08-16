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
            return new ProdutoDAO().Listar();
        }
        #endregion
    }
}

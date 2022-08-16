using DAO;
using GTIMVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTIMVC.BL
{
    public class CategoriaBL
    {
        #region Listar
        public List<Categoria> Listar()
        {
            return new CategoriaDao().Listar();
        }
        #endregion
    }
}

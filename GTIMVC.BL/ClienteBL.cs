using DAO;
using GTIMVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTIMVC.BL
{
    public class ClienteBL
    {
        #region Inserir
        public int Inserir(Cliente cliente)
        {
            ClienteDao dao = new ClienteDao();

            return dao.Inserir(cliente);


        }
        #endregion
        //-------------------------------------------------------------------------------------
        #region Atualizar
        public void Atualizar(Cliente cliente)
        {

            new ClienteDao().Atualizar(cliente);
        }
        #endregion
        //-------------------------------------------------------------------------------------
        #region Deletar
        public void Excluir(int intIdCliente)
        {
            ClienteDao dao = new ClienteDao();
            dao.Excluir(intIdCliente);

        }
        #endregion
        //-------------------------------------------------------------------------------------
        #region Listar
        public List<Cliente> Listar()
        {
            return new ClienteDao().Listar();
        }
        #endregion
        //-------------------------------------------------------------------------------------
        #region Obter
        public Cliente Obter(int Id)
        {
            return new ClienteDao().Obter(Id);
        }
        #endregion

    }
}

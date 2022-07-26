using GTIMVC.BL;
using GTIMVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GTIMVC.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente

        public ActionResult Home()
        {

            return View();
        }
        public ActionResult Index()
        {
            ClienteBL clienteBL = new ClienteBL();
            List<Cliente> clientes =  clienteBL.Listar();

            return View(clientes); 
        }

         public ActionResult Form()
        {
            ClienteBL clienteBL = new ClienteBL();
            var clientes = clienteBL.Listar();

            return View(clientes);
        }

        public ActionResult FormAlterar(int id)
        {
            ClienteBL clienteBL = new ClienteBL();
            var clientes = clienteBL.Obter(id);

            return View(clientes);
        }

        public ActionResult FormExcluir(int id)
        {
            ClienteBL clienteBL = new ClienteBL();
            var clientes = clienteBL.Obter(id);
            return View(clientes);
        }

        [HttpPost]
        public ActionResult Adicionar(Cliente cliente)
        {
            ClienteBL clienteBL = new ClienteBL();
            clienteBL.Inserir(cliente);

            return RedirectToAction("Index", "Cliente");
        }


        [HttpPost]
        public ActionResult Atualizar(Cliente cliente)
        {
            ClienteBL clienteBL = new ClienteBL();
            clienteBL.Atualizar(cliente);

            return RedirectToAction("Index", "Cliente");
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            ClienteBL clienteBL = new ClienteBL();
            clienteBL.Excluir(id);

            return RedirectToAction("Index", "Cliente");
        }

        public ActionResult Detalhes(int id)
        {
            ClienteBL clienteBL = new ClienteBL();
            var  clientes  = clienteBL.Obter(id);

            return View(clientes);
        }



    }
}
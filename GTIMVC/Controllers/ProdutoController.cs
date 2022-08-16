using GTIMVC.BL;
using GTIMVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GTIMVC.Controllers
{
    public class ProdutoController : Controller
    {
        // GET: Produto

        public ActionResult Index()
        {
            ProdutoBL produtoBL = new ProdutoBL();
            List<Produto> produtos = produtoBL.Listar();

            return View(produtos);
        }
    }
}
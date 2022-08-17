using GTIMVC.BL;
using GTIMVC.MODEL;
using GTIMVC.Models;
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

        public ActionResult FormProduto()
        {
            ProdutoBL produtoBL = new ProdutoBL();
            var produtos = produtoBL.Listar();

            ListarCategorias();

            return View(produtos);
        }

        public ActionResult FormAlterar(int id)
        {
            ProdutoBL produtoBL = new ProdutoBL();
            var produto = produtoBL.Obter(id);

            ListarCategorias();

            return View(produto);
        }

        public ActionResult FormExcluir(int id)
        {
            ProdutoBL produtoBL = new ProdutoBL();
            var produto = produtoBL.Obter(id);
            return View(produto);
        }

            [HttpPost]
        public ActionResult Adicionar(Produto produto)
        {
            ProdutoBL produtoBL = new ProdutoBL();
            produtoBL.Inserir(produto);

            return RedirectToAction("Index", "produto");
        }

        [HttpPost]
        public ActionResult Atualizar(Produto produto)
        {
            ProdutoBL produtoBL = new ProdutoBL();
            produtoBL.Atualizar(produto);

            return RedirectToAction("Index", "Produto");
        }

        private void ListarCategorias()
        {
            ViewBag.Categorias = new SelectList

                (
                    new CategoriaBL().Listar(),
                  "Id",
                  "Descricao"
                );

        }
    }
}
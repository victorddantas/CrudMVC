using GTIMVC.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GTIMVC.Models
{
    public class ProdutoViewModel
    {

        public ProdutoViewModel()
        {
            Produto = new Produto();
            Produtos = new List<Produto>();
            Categoria = new Categoria();
        }
        public Produto Produto { get; set; }
        public List<Produto> Produtos { get; set; }
        public Categoria Categoria { get; set; }

    }

   
}
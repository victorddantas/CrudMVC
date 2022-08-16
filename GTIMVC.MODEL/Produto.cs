using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTIMVC.MODEL
{
    public class Produto
    {
        public int IDProduto { get; set; }
        public int IDProdutoCategoria { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Fornecedor { get; set; }
        public double Peso { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTIMVC.MODEL
{
    public class Produto
    {
        public int Id { get; set; }
        public Categoria Categoria{ get; set; }
        public int IdCategoria { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Fornecedor { get; set; }
        public double Peso { get; set; }
    }
}

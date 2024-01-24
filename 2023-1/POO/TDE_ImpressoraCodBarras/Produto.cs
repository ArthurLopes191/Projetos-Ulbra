using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDE_ImpressoraCodBarras
{
    public class Produto
    {
        public int count = 0;
        public int Id { get; private set; }
        public string Codbarras { get; private set; }
        public double Preco { get; set; }

        public Produto(string codbarras, double preco)
        {
            count++;
            this.Id = this.count;
            this.Codbarras = codbarras;
            this.Preco = preco;
        }
    }
}
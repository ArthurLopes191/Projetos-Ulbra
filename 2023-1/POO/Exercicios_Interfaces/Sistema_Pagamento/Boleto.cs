using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Pagamento
{
    public class Boleto : IPagamento
    {
        public string Pagar(double valor)
        {
            return $"Pagando R${valor} com Boleto";
        }
    }
}
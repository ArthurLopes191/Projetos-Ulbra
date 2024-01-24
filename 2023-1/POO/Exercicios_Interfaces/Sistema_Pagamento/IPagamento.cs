using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Pagamento
{
    public interface IPagamento
    {
        public string Pagar(double valor);
    }
}
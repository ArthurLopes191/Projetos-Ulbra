using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Escolar
{
    public class Escola
    {
        public string ApresentarPessoa(IPessoa pessoa)
        {
            return pessoa.Falar();
        }
    }
}
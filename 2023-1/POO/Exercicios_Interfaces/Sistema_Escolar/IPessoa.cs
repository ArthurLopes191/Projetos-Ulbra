using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Escolar
{
    public interface IPessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Falar();
    }
}
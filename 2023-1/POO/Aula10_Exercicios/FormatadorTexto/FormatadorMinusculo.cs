using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula10_Exercicios.FormatadorTexto
{
    public class FormatadorMinusculo: IFormatadorTexto
    {
        public string Formatar(string texto)
        {
            return "formatado minusculo";
        }
    }
}
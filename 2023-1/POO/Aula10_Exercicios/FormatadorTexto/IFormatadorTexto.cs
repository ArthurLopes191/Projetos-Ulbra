using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Crie uma interface IFormatadorTexto com o método Formatar(string texto). Em seguida, crie as classes FormatadorMaiusculo, FormatadorMinusculo e FormatadorInvertido que implementam a interface IFormatadorTexto com sua própria implementação do método Formatar(). Em um programa, instancie as três classes e use cada uma para formatar um texto diferente.

namespace Aula10_Exercicios.FormatadorTexto
{
    public interface IFormatadorTexto
    {
        public string Formatar(string texto);
    }
}
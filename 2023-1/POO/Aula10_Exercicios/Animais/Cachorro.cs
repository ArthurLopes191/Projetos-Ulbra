using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula10_Exercicios.Animais
{
    public class Cachorro : IAnimais
    {
        public string EmitirSom()
        {
            return "AuAu";
        }
    }
}
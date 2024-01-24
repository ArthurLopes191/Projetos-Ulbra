using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula10_Exercicios.Animais
{
    public class Gato : IAnimais
    {
        public string EmitirSom()
        {
            return "Miau Miau";
        }
    }
}
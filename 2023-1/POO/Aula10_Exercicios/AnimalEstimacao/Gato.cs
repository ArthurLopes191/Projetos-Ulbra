using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula10_Exercicios.AnimalEstimacao
{
    public class Gato : IAnimalEstimacao
    {
        public string Nome { get; set; }
        public string Dono { get; set; }
    }
}
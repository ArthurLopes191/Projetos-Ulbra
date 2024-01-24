using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//Crie uma interface IAnimalEstimacao com as propriedades Nome e Dono. Em seguida, crie as classes Cachorro e Gato que implementam a interface IAnimalEstimacao com suas próprias implementações das propriedades. Em um programa, instancie as duas classes e defina os valores das propriedades para cada uma.

namespace Aula10_Exercicios.AnimalEstimacao
{
    public interface IAnimalEstimacao
    {
        public string Nome { get; set; }

        public string Dono { get; set; }
    }
}
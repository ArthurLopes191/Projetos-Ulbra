using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


// Crie uma interface IAnimal com o método EmitirSom(). Em seguida, crie as classes Cachorro, Gato e Papagaio que implementam a interface IAnimal com sua própria implementação do método EmitirSom(). Em um programa, instancie as três classes e chame o método EmitirSom() de cada uma.

namespace Aula10_Exercicios
{
    public interface IAnimais
    {
        public string EmitirSom();
    }
}
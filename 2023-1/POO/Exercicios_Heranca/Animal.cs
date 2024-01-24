/*Crie uma classe base chamada "Animal" que tenha uma propriedade "Nome" e um método "Falar()". Em seguida, crie duas classes derivadas chamadas "Cachorro" e "Gato" que herdam da classe "Animal" e implementam o método "Falar()" de maneiras diferentes. Por exemplo, o método "Falar()" da classe "Cachorro" pode imprimir "Au au!", enquanto o método "Falar()" da classe "Gato" pode imprimir "Miau!". A classe animal não poderá ser instanciada. Teste o código na classe program.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Heranca
{
    public abstract class Animal
    {
        public String Nome { get; set; }

        public Animal(String nome)
        {
            this.Nome = nome;
        }

        public abstract void Falar();
    }
}
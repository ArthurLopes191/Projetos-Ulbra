/*Crie uma classe base chamada "Veiculo" que tenha uma propriedade "Modelo" e um método "Acelerar()". Em seguida, crie duas classes derivadas chamadas "Carro" e "Moto" que herdam da classe "Veiculo" e implementam o método "Acelerar()" de maneiras diferentes. Por exemplo, o método "Acelerar()" da classe "Carro" pode imprimir "Acelerando carro!", enquanto o método "Acelerar()" da classe "Moto" pode imprimir "Acelerando moto!". Teste o código na classe program*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Heranca
{
    public abstract class Veiculo
    {
        public String Modelo { get; set; }

        public Veiculo(String modelo)
        {
            this.Modelo = modelo;
        }

        public abstract void Acelerar();
    }
}
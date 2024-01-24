using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Heranca
{
    public class Carro : Veiculo
    {

        public Carro(String modelo) : base(modelo)
        {
            this.Modelo = modelo;
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando carro");
        }
    }
}
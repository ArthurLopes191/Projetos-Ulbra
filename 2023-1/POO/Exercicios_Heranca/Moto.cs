using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Heranca
{
    public class Moto : Veiculo
    {

        public Moto(String modelo) : base(modelo)
        {
            this.Modelo = modelo;
        }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerando moto");
        }
    }
}
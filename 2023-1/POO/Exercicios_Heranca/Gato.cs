using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Heranca
{
    public class Gato : Animal
    {
       
        public Gato(String nome) : base(nome)
        {
            this.Nome = nome;
        }
        public override void Falar(){
            Console.WriteLine("Miau miau");
        }
    
    }
}
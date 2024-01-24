using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_Heranca
{
    public class Heroi : Personagem
    {
    
        public Heroi(String nome, int forca, int inteligencia, String poderes) : base(nome, forca, inteligencia, poderes)
        {
            this.Nome = nome;
            this.Forca = forca;
            this.Inteligencia = inteligencia;
            this.Poderes = poderes;
        }

        public void Lutar(String nome){
            Console.WriteLine( nome + " está lutando");
        }
    }
}
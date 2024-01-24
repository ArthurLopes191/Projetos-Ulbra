using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratique_c_
{
    public class MediaNotas
    {
        public double media{get; set;}

        public double VerificarMedia(){
            double notas, soma = 0;

            for(int i = 0; i < 3; i++){
                Console.WriteLine("Digite a nota " + (i + 1));
                notas = Convert.ToDouble(Console.ReadLine()); 
                soma += notas;             
               }
               media = soma/3.0;
               return this.media;

        }
                
    }
}
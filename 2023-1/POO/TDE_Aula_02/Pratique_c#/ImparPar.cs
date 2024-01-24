using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratique_c_
{
    public class ImparPar
    {
        public int result{get; set;}

        public double Verificar(int num){
            if (2 % num == 0)
            {
                Console.WriteLine("O numero " + num + " é par");
            }else{
                Console.WriteLine("O numero " + num + " é impar");
            }

            return this.result;
        }
    }
}
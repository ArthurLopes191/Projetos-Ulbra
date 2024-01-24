using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratique_c_
{
    public class NumerosPares
    {
        public void VerificarPares(int num){
            
            for(int i = 2; i < num; i+=2){            
                Console.WriteLine(i);
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PessoasInfo
{
    public class Pessoa
    {

        public String Nome{get; set;}
        public int Idade{get; set;}
        public void Apresentar(){
            Console.WriteLine("O nome da pessoa é: " + Nome );
            Console.WriteLine("A idade da pessoa é: " + Idade );
        }
    }
}
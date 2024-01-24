using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Pessoas_Cidades
{
    public class City
    {
        public int Id{ get; set; }

        public string Nome { get; set; }

        public City(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

    }
}
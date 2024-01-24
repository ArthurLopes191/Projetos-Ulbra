using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Pessoas
{
    public class Person
    {
        public string Nome { get; set; }="";  
        public int Id { get; private set; }
        public string Telefone { get; set; }=""; 

        public Person(string nome, int id, string telefone)
        {
            this.Nome = nome;
            this.Id = id;
            this.Telefone = telefone;
        }

    }
}
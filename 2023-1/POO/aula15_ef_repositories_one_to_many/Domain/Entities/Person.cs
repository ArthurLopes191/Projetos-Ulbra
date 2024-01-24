using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestandoORM.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Idade { get; set; }
        
        public City City { get; set; }

        
    }

}
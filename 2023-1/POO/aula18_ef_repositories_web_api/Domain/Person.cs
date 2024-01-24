using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace aula18_ef_repositories_web_api.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        public City City { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace aula18_ef_repositories_web_api.Domain
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Person> People { get; set; }
    }
}
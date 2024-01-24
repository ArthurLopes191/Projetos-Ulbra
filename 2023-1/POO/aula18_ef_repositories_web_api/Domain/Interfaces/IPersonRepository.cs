using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula18_ef_repositories_web_api.Domain;

namespace aula18_ef_repositories_web_api.Domain.Interfaces
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
        
    }
}
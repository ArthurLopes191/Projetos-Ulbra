using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestandoORM.Domain.Entities;

namespace TestandoORM.Domain.Interfaces
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
        
    }
}
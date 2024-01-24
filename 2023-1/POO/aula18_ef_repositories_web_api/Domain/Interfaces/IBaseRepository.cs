using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula18_ef_repositories_web_api.Domain;

namespace aula18_ef_repositories_web_api.Domain.Interfaces
{
    public interface IBaseRepository<Entity> where Entity : class
    {
        Entity GetById(int entityId);
        IList<Entity> GetAll();
        void Save(Entity entity);
        void Delete(int entityId);
        void Update(Entity entity);

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestandoORM.Data.Context;
using TestandoORM.Domain.Entities;
using TestandoORM.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace TestandoORM.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {

        private readonly MyContext context ;

        public PersonRepository(MyContext  context)
        {
            this.context = context;
        }

        public void Delete(int entityId)
        {
            var p = GetById(entityId);
            context.People.Remove(p);
            context.SaveChanges();
        }

        public IList<Person> GetAll()
        {
           return context.People.Include(x=>x.City).ToList();
        }

        public Person GetById(int entityId)
        {
            return context.People.Include(x=>x.City).SingleOrDefault(x=>x.Id == entityId);
        }

        public void Save(Person entity)
        {
            entity.City = context.Cities.Find(entity.City.Id);
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(Person entity)
        {
            context.People.Update(entity);
            context.SaveChanges();
        }
    }
}
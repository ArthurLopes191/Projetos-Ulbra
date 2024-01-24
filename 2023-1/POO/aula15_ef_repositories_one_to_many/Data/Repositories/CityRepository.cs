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
    public class CityRepository : ICityRepository
    {
        private readonly MyContext context ;

        public CityRepository(MyContext  context)
        {
            this.context = context;
        }

        public void Delete(int entityId)
        {
            var p = GetById(entityId);
            context.Cities.Remove(p);
            context.SaveChanges();
        }

        public IList<City> GetAll()
        {
            return context.Cities.ToList();
        }

        public City GetById(int entityId)
        {
            return context.Cities.SingleOrDefault(x=>x.Id == entityId);
        }

        public void Save(City entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Update(City entity)
        {
            context.Cities.Update(entity);
            context.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestandoORM.Domain.Entities;

namespace TestandoORM.Data.Context
{
    public class MyContext : DbContext
    {
        protected string DbPath { get; }
        public MyContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "TestandoORM.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Person> People {get; set;}

        public DbSet<City> Cities {get; set;}
    }
}
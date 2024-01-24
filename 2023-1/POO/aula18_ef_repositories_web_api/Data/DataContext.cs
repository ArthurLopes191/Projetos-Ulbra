
using aula18_ef_repositories_web_api.Domain;
using Microsoft.EntityFrameworkCore;

namespace aula18_ef_repositories_web_api.Data
{
    public class DataContext : DbContext
    {
       public string DbPath { get; }

        public DataContext()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "TestEfSegunda.db");
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Person> People { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
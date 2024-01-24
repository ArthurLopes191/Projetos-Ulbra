using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Pessoas_Cidades
{
    public class CityRepository
    {
        public static List<City> cityMaster = new List<City>();

        public void AdicionarCity()
        {
            
                cityMaster.AddRange(new []{
                    new City(1, "Capão da canoa"),
                    new City(2, "Torres"),
                    new City(3, "Arroio do Sal"),
                    new City(4, "Osório"),
                    new City(5, "Tramandaí")
                    });
            
            
        }

        public City findCity(int id){
            City cityFound = cityMaster.Find(p => p.Id == id);
            if(cityFound == null)
            {
                Console.WriteLine("\nCidade não encontrada!");
            }
            return cityFound;
        }

        public void MostrarCity(){
            if(cityMaster.Count == 0){
                Console.WriteLine("\nNão há nenhuma Cidade cadastrada");
            }
            Console.WriteLine("CIDADES:");
            foreach (var p in cityMaster)
            {
                Console.WriteLine($"Id: {p.Id} - Nome: {p.Nome} ");
            }
        }

        
    }
}
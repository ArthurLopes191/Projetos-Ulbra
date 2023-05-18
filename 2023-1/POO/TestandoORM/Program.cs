﻿using TestandoORM.Data.Context;
using TestandoORM.Data.Repositories;
using TestandoORM.Domain.Entities;
using TestandoORM.Domain.Interfaces;

var db = new MyContext();
//Console.WriteLine("Inserting a new person");
//var person = new Person {Id = 5, Nome = "Lucas", Idade = DateTime.Now};

IPersonRepository _personRepository = new PersonRepository(db);
//_personRepository.Save(person);
ICityRepository _cityRepository = new CityRepository(db);
var city = new City {Id = 1, Name = "Capão da canoa"};
//Console.WriteLine("Lista de pessoas");
//GetAllPeople();

Console.WriteLine("Lista de cidades");
GetAllCities();

Console.WriteLine("GetById: ");

var p = _personRepository.GetById(4);

Console.WriteLine($"Id: {p.Id} | Nome: {p.Nome} | Idade: {p.Idade}");


//Console.WriteLine("Deleting: ");
// _personRepository.Delete(3);
//GetAllPeople();

Console.WriteLine("Update");
p.CityId = 1;
_personRepository.Update(p); 
//GetAllPeople();

// -------------------------------------------
void GetAllPeople()
{
var people = _personRepository.GetAll();
foreach(var item in people)
{

    Console.WriteLine($"Id: {item.Id} | Nome: {item.Nome} | Idade: {item.Idade}");
}
}

void GetAllCities()
{
var cities = _cityRepository.GetAll();
foreach(var item in cities)
{

    Console.WriteLine($"Id: {item.Id} | Nome: {item.Name} |");
}
}
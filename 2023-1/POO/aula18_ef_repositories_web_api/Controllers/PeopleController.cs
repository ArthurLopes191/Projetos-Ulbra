using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula18_ef_repositories_web_api.Data.Repositories;
using aula18_ef_repositories_web_api.Domain;
using aula18_ef_repositories_web_api.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace aula18_ef_repositories_web_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonRepository repository;

        public PeopleController()
        {
            this.repository = new PersonRepository();
        }

        [HttpGet]
        public IEnumerable<Person>Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return repository.GetById(id);
        }


        [HttpPost]
        public IActionResult Post([FromBody]Person item)
        {
            repository.Save(item);
            return Ok(new{
                statusCode=200,
                message = "Cadastro com sucesso",
                item
            });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok(new{
                statusCode=200,
                message = "Deletado com sucesso",
            });
        }

        [HttpPut]
        public IActionResult Put([FromBody]Person item)
        {
            repository.Update(item);
            return Ok(new{
                statusCode=200,
                message = item.Name + " Pessoa atualizada com sucesso",
                item
            });
        }
    }
}
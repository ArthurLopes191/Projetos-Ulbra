using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2;
using Ap2.Data.Repositories;
using Ap2.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ap2_AS_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConsultasController : ControllerBase
    {
        private readonly IConsultaRepository repository;

        public ConsultasController()
        {
            this.repository = new ConsultaRepository();
        }

        [HttpGet]
        public IEnumerable<Consulta>Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Consulta Get(int id)
        {
            return repository.GetById(id);
        }


        [HttpPost]
        public IActionResult Post([FromBody]Consulta item)
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
        public IActionResult Put([FromBody]Consulta item)
        {
            repository.Update(item);
            return Ok(new{
                statusCode=200,
                message = " Endereco atualizada com sucesso",
                item
            });
        }
    }
}
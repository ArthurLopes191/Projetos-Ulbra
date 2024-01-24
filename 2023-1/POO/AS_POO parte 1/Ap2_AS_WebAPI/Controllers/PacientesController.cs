using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ap2;
using Ap2.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ap2_AS_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacientesController : ControllerBase
    {
        private readonly IPacienteRepository repository;

        public PacientesController()
        {
            this.repository = new PacienteRepository ();
        }

        [HttpGet]
        public IEnumerable<Paciente>Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Paciente Get(int id)
        {
            return repository.GetById(id);
        }


        [HttpPost]
        public IActionResult Post([FromBody]Paciente item)
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
        public IActionResult Put([FromBody]Paciente item)
        {
            repository.Update(item);
            return Ok(new{
                statusCode=200,
                message = item.Nome + " Paciente atualizada com sucesso",
                item
            });
        }
    }
}
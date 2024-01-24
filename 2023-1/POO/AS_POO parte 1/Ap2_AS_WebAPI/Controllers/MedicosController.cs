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
    public class MedicosController : ControllerBase
    {
        private readonly IMedicoRepository repository;

        public MedicosController()
        {
            this.repository = new MedicoRepository ();
        }

        [HttpGet]
        public IEnumerable<Medico>Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Medico Get(int id)
        {
            return repository.GetById(id);
        }


        [HttpPost]
        public IActionResult Post([FromBody]Medico item)
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
        public IActionResult Put([FromBody]Medico item)
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
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
    public class EnderecosController : ControllerBase
    {
        private readonly IEnderecoRepository repository;

        public EnderecosController()
        {
            this.repository = new EnderecoRepository ();
        }

        [HttpGet]
        public IEnumerable<Endereco>Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public Endereco Get(int id)
        {
            return repository.GetById(id);
        }


        [HttpPost]
        public IActionResult Post([FromBody]Endereco item)
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
        public IActionResult Put([FromBody]Endereco item)
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
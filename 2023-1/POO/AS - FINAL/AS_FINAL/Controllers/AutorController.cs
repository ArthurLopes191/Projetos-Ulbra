using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_FINAL.Domain.Entities;
using AS_FINAL.Domain.Interfaces;
using AS_FINAL.Domain.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AS_FINAL.Controllers
{
     [Route("api/autores")]
    public class AutorController : ControllerBase
    {
       private readonly IAutorRepository _autorRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AutorController(IAutorRepository autorRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _autorRepository = autorRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var autores = _mapper.Map<IList<AutorDTO>>(await _autorRepository.GetAllAsync());
            return HttpMessageOk(autores);
        }
        
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var autor = _mapper.Map<AutorDTO>(await _autorRepository.GetByIdAsync(id));
            return HttpMessageOk(autor);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] AutorViewModel model)
        {
            var autor = _mapper.Map<Autor>(model); 
            _autorRepository.Save(autor);
            await _unitOfWork.Commit();

            return HttpMessageOk(_mapper.Map<AutorDTO>(autor));
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] AutorViewModel model)
        {
            var autor = await _autorRepository.GetByIdAsync(id);
            if (autor == null) return NotFound();

            autor.Nome = model.Nome;
            autor.Telefone = model.Telefone;
            autor.LivroId = model.LivroId;
           

            _autorRepository.Update(autor);
            await _unitOfWork.Commit();

            return Ok(autor);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var autor = await _autorRepository.GetByIdAsync(id);

            if (autor == null) return NotFound();
            var wasRemoved = _autorRepository.Delete(id);
            await _unitOfWork.Commit();

            return HttpMessageOk(id);
        }

        private IActionResult HttpMessageOk(dynamic data = null)
        {
            if (data == null)
                return NoContent();
            else
                return Ok(new
                {
                    data
                });
        }

        private IActionResult HttpMessageError(string message = "")
        {
            return BadRequest(new
            {
                message
            });
        }
    }
}
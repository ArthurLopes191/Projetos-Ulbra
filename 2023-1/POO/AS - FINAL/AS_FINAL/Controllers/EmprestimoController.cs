using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_FINAL.Domain.DTOs;
using AS_FINAL.Domain.Entities;
using AS_FINAL.Domain.Interfaces;
using AS_FINAL.Domain.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AS_FINAL.Controllers
{
    [Route("api/emprestimos")]
    public class EmprestimoController : ControllerBase
    {
         private readonly IEmprestimoRepository _emprestimoRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmprestimoController(IEmprestimoRepository emprestimoRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _emprestimoRepository = emprestimoRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var emprestimos = _mapper.Map<IList<EmprestimoDTO>>(await _emprestimoRepository.GetAllAsync());
            return HttpMessageOk(emprestimos);
        }
        
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var emprestimo = _mapper.Map<EmprestimoDTO>(await _emprestimoRepository.GetByIdAsync(id));
            return HttpMessageOk(emprestimo);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] EmprestimoViewModel model)
        {
            var emprestimo = _mapper.Map<Emprestimo>(model);
            
            /*
            if (model.DataDevolucao == null)
            {
                emprestimo.DataDevolucao = DateTime.MinValue;
            }
            */
            emprestimo.DataDevolucao = null;

            _emprestimoRepository.Save(emprestimo);
            await _unitOfWork.Commit();

            return HttpMessageOk(_mapper.Map<EmprestimoDTO>(emprestimo));
        }


        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] EmprestimoViewModel model)
        {
            if (!ModelState.IsValid) return HttpMessageError("Dados incorretos");

            var emprestimo = await _emprestimoRepository.GetByIdAsync(id);
            if (emprestimo == null) return NotFound();

            emprestimo.DataEmprestimo = model.DataEmprestimo;
            emprestimo.DataDevolucao = model.DataDevolucao; 
            emprestimo.LivroId = model.LivroId;
            emprestimo.UsuarioId = model.UsuarioId;

            _emprestimoRepository.Update(emprestimo);
            await _unitOfWork.Commit();

            return Ok(emprestimo);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var emprestimo = await _emprestimoRepository.GetByIdAsync(id);

            if (emprestimo == null) return NotFound();
            var wasRemoved = _emprestimoRepository.Delete(id);
            await _unitOfWork.Commit();

            return HttpMessageOk(id);
        }

        [HttpPost("devolver-livro/{id:int}")]
        public async Task<IActionResult> DevolverLivroAsync(int id)
        {
            var emprestimo = await _emprestimoRepository.GetByIdAsync(id);

            if (emprestimo == null) return NotFound();

            // Realizar ações necessárias para a devolução do livro (lógica de negócio específica)
            
            //var wasRemoved = _emprestimoRepository.Delete(id);
            emprestimo.DataDevolucao = DateTime.Now;
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
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
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
         private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioRepository usuarioRepository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _usuarioRepository = usuarioRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var usuarios = _mapper.Map<IList<UsuarioDTO>>(await _usuarioRepository.GetAllAsync());
            return HttpMessageOk(usuarios);
        }
        
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var usuario = _mapper.Map<UsuarioDTO>(await _usuarioRepository.GetByIdAsync(id));
            return HttpMessageOk(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] UsuarioViewModel model)
        {
            var usuario = _mapper.Map<Usuario>(model); 
            _usuarioRepository.Save(usuario);
            await _unitOfWork.Commit();

            return HttpMessageOk(_mapper.Map<UsuarioDTO>(usuario));
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] UsuarioViewModel model)
        {
            var usuario = await _usuarioRepository.GetByIdAsync(id);
            if (usuario == null) return NotFound();

            usuario.Nome = model.Nome;
            usuario.Telefone = model.Telefone;
            usuario.Documento = model.Documento;

            // Mapeia a lista de autores do LivroViewModel para a lista de autores do Livro
            usuario.Emprestimos = _mapper.Map<List<Emprestimo>>(model.Emprestimos);

            _usuarioRepository.Update(usuario);
            await _unitOfWork.Commit();

            return Ok(usuario);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> RemoveAsync(int id)
        {
            var usuario = await _usuarioRepository.GetByIdAsync(id);

            if (usuario == null) return NotFound();
            var wasRemoved = _usuarioRepository.Delete(id);
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
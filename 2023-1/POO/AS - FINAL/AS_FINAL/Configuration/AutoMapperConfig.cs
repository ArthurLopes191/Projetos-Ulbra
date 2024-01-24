using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AS_FINAL.Domain.DTOs;
using AS_FINAL.Domain.Entities;
using AS_FINAL.Domain.ViewModels;
using AutoMapper;

namespace AS_FINAL.Configuration
{
    public class AutoMapperDTOs : Profile
    {
        public AutoMapperDTOs()
        {
            CreateMap<Autor, AutorDTO>().PreserveReferences().MaxDepth(0);
         
            CreateMap<Livro, LivroDTO>().PreserveReferences().MaxDepth(0);
            
            CreateMap<Usuario, UsuarioDTO>().PreserveReferences().MaxDepth(0);
            
            CreateMap<Emprestimo, EmprestimoDTO>().PreserveReferences().MaxDepth(0);
        }
    }

    public class AutoMapperViewModels : Profile
    {
        public AutoMapperViewModels()
        {
            CreateMap<AutorViewModel, Autor>();
           
            CreateMap<LivroViewModel, Livro>();
         
            CreateMap<UsuarioViewModel, Usuario>();
           
           CreateMap<EmprestimoViewModel, Emprestimo>();
        }
    }
}

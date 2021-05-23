using AutoMapper;
using puertaMagica.BL.Contracts;
using puertaMagica.Core.DTO;
using puertaMagica.DAL.Contracts;
using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puertaMagica.BL.Inplementations
{
    public class UsuarioBL : IUsuarioBL
    {
        public IUsuarioRepository usuarioRepository { get; set; }

        public IMapper mapper { get; set; }

        public UsuarioBL(IUsuarioRepository usuarioRepository, IMapper mapper)
        {
            this.usuarioRepository = usuarioRepository;
            this.mapper = mapper;
        }

        public int Insertar(UsuarioDTO usuarioDTO)
        {
            
            var usuario = mapper.Map<UsuarioDTO, Usuario>(usuarioDTO);
           return usuarioRepository.Insertar(usuario);
        }

        public void Actualizar(UsuarioDTO usuarioDTO)
        {
            var usuario = mapper.Map<UsuarioDTO, Usuario>(usuarioDTO);
            usuarioRepository.Actualizar(usuario);
        }

        public void Delete(string username)
        {
            usuarioRepository.Delete(username);
        }
    }
}

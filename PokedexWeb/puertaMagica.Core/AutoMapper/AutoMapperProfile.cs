using puertaMagica.Core.DTO;
using puertaMagica.DAL.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace puertaMagica.Core.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UsuarioDTO, Usuario>();
            CreateMap<Usuario, UsuarioDTO>();
            CreateMap<LoginDTO, Usuario>();
            CreateMap<PokemonDTO, Pokemon>();
            CreateMap<Pokemon, PokemonDTO>();

        }
    }
}
using AutoMapper;
using puertaMagica.BL.Contracts;
using puertaMagica.Core.DTO;
using puertaMagica.DAL.Contracts;
using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puertaMagica.BL.Inplementations
{
   public class PokemonBL : IPokemonBL
    {


        public IPokemonRepository pokemonRepository { get; set; }

        public IMapper mapper { get; set; }

        public PokemonBL(IPokemonRepository pokemonRepository, IMapper mapper)
        {
            this.pokemonRepository = pokemonRepository;
            this.mapper = mapper;
        }

        public int Insertar(PokemonDTO pokemonDTO)
        {

            var pokemon = mapper.Map<PokemonDTO, Pokemon>(pokemonDTO);
            return pokemonRepository.Insertar(pokemon);
        }

        public int Actualizar(PokemonDTO pokemonDTO)
        {
            var pokemone = mapper.Map<PokemonDTO, Pokemon>(pokemonDTO);
            return pokemonRepository.Actualizar(pokemone);
        }

        public int Delete(string Nombre)
        {
          return pokemonRepository.Delete(Nombre);
        }

        public List<Pokemon> getAll()
        {
            // mapeo de Pokemon a PokemonDTO
            return pokemonRepository.getAll();
        }

        public Pokemon getId(int numeroP)
        {
            return pokemonRepository.getId(numeroP);
        }


    }
}

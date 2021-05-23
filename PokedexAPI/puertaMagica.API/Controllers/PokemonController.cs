using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using puertaMagica.BL.Contracts;
using puertaMagica.Core.DTO;
using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace puertaMagica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : Controller
    {
        public IPokemonBL pokemonBL { get; set; }

        public PokemonController(IPokemonBL pokemonBL)
        {

            this.pokemonBL = pokemonBL;

        }
        [HttpPost]
        public int Crear(PokemonDTO pokemon)
        {

            return pokemonBL.Insertar(pokemon);
        }

        [HttpDelete]
        public int borrar(string Nombre)
        {
            return pokemonBL.Delete(Nombre);
        }

        [HttpPut]
        public void Actualizar(PokemonDTO pokemon)
        {
            pokemonBL.Actualizar(pokemon);
        }

        [HttpGet]
        [Produces("application/json")]
        public List<Pokemon> getAll()
        {
            List<Pokemon> pipo =  pokemonBL.getAll();
            return pipo;
        }

        [HttpGet("id")]
        public Pokemon getId(int numeroP)
        {
            return pokemonBL.getId(numeroP);
        }

    }
}

using puertaMagica.Core.DTO;
using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Esta clase se encarga de procesar la infromacion sobre pokemons y enviarla o conectarla a la web
/// </summary>
namespace puertaMagica.BL.Contracts
{
    public interface IPokemonBL
    {

      public  int Insertar(PokemonDTO pokemon);
      public  int Delete(string Nombre);

       public  int Actualizar(PokemonDTO pokemonDTO);

        public List<Pokemon> getAll();

        public Pokemon getId(int numeroP);


    }
}

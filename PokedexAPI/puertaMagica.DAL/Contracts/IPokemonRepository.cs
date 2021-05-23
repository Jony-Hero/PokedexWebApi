using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Esta clase se va a encargar de transportar la informacion de la base de datos sobre pokemons
/// </summary>
namespace puertaMagica.DAL.Contracts
{
   public interface IPokemonRepository
    {
        public int Insertar(Pokemon pokemon);
        public  int Delete(string Nombre);

        public int Actualizar(Pokemon pokemon);

        public List<Pokemon> getAll();

        public Pokemon getId(int numeroP);

    }
}

using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Esta clase se va a encargar de transportar la informacion de la base de datos sobre los usuarios
/// </summary>
namespace puertaMagica.DAL.Contracts
{
    public interface IUsuarioRepository
    {
        int Insertar(Usuario usuario);
        void Delete(string username);

        void Actualizar(Usuario usuario);

    }
}

using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puertaMagica.DAL.Contracts
{
    public interface IUsuarioRepository
    {
        int Insertar(Usuario usuario);
        void Delete(string username);

        void Actualizar(Usuario usuario);

    }
}

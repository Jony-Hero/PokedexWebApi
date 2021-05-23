using puertaMagica.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Esta clase se encarga de procesar la infromacion sobre usuarios y conectar la  a la web
/// </summary>
namespace puertaMagica.BL.Contracts
{
    public interface IUsuarioBL
    {
   
        int Insertar(UsuarioDTO usuario);
        void Delete(string username);

        void Actualizar(UsuarioDTO usuario);

        
    }
}

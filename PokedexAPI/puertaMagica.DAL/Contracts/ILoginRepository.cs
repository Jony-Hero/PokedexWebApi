using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Esta clase se va a encargar de transportar la informacion de la base de datos sobre usuarios
/// </summary>
namespace puertaMagica.DAL.Contracts
{
    public interface ILoginRepository
    {
        public bool Login(Usuario usuario);
       
    }
}

using puertaMagica.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Esta clase se encarga de procesar la infromacion sobre usuario y enviarla o conectarla  a la web
/// </summary>
namespace puertaMagica.BL.Contracts
{
    public interface ILoginBL
    {
        public bool Login(LoginDTO loginDTO);
    }
}

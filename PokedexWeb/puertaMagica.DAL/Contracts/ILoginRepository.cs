using puertaMagica.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puertaMagica.DAL.Contracts
{
    public interface ILoginRepository
    {
        public bool Login(Usuario usuario);
       
    }
}
